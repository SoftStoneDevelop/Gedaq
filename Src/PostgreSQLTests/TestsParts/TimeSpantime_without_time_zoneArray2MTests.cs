

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
    internal partial interface ITimeSpanListtime_without_time_zoneArray
    {
    }
    
    internal partial class TimeSpanListtime_without_time_zoneArray : ITimeSpanListtime_without_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray2mi(
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
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
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
INSERT INTO public.timespantime_without_time_zonearray2mi(
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
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
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

                changedRows =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInner(connection, 1876000264, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInner(connection, 1359375871, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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

                changedRows = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1072490419, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1557342830, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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

                id =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 2093407547, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

});
                Assert.That(id, Is.EqualTo(2093407547));

                id =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 140991566, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

});
                Assert.That(id, Is.EqualTo(140991566));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 144283911, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

});
                Assert.That(id, Is.EqualTo(144283911));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1407946917, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

});
                Assert.That(id, Is.EqualTo(1407946917));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 439230713, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

}, null);
                Assert.That(id, Is.EqualTo(439230713));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1997921769, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

});
                Assert.That(id, Is.EqualTo(1997921769));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 228769667, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

});
                Assert.That(id, Is.EqualTo(228769667));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 250950821, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

});
                Assert.That(id, Is.EqualTo(250950821));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2065242575, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

});
                Assert.That(id, Is.EqualTo(2065242575));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1463896761, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

}, null);
                Assert.That(id, Is.EqualTo(1463896761));

                id = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1041215353, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

}, null);
                Assert.That(id, Is.EqualTo(1041215353));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zonearray2mi_id
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
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zonearray2mi_id", 
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

                changedRows =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModel(connection, 2143132353, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModel(connection, 1951249296, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

}, 1876000264);
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

                changedRows = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelAsync(connection, 617407514, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelAsync(connection, 721265519, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

}, null, 1359375871);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zonearray2mi_id
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
    timespantime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zonearray2mi_id", 
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
                List<TimeSpantime_without_time_zoneArray2M> models = null;
                TimeSpantime_without_time_zoneArray2M model = null;

                models =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturning(connection, 1163976504, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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

                models =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturning(connection, 685753948, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

}, 1072490419).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturning(connection, 526720790, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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

                models =  ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturning(connection, 618758011, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

}, null, 1557342830).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpantime_without_time_zoneArray2M> models = null;
                TimeSpantime_without_time_zoneArray2M model = null;

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1341347086, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2066743975, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

}, null, 2093407547).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 898520110, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1490270908, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

}, 140991566).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 432621887, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 637902018, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

}, 144283911).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 318059118, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 74780407, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

}, null, 1407946917).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 824843026, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1599056800, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

}, 439230713).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 278043003, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1285290855, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

}, null, 1997921769).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2075624424, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 460205827, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

}, 228769667).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1903315673, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 717416002, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

}, null, 250950821).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1257229835, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 898152788, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

}, null, 2065242575).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1822372806, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 575838185, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

}, null, 1463896761).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1558222350, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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

                models = await ((ITimeSpanListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 933025369, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

}, null, 1041215353).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
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
FROM public.timespantime_without_time_zonearray2m m
LEFT JOIN public.timespantime_without_time_zonearray2mi mi ON mi.id = m.timespantime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
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
                var models =  ((ITimeSpanListtime_without_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListtime_without_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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
FROM public.timespantime_without_time_zonearray2m m
LEFT JOIN public.timespantime_without_time_zonearray2mi mi ON mi.id = m.timespantime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
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
                var models =  ((ITimeSpanListtime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListtime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 617407514);
                var models =  ((ITimeSpanListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(22));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 1163976504);
                var models = await ((ITimeSpanListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(12));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListtime_without_time_zoneArray)
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
                 foreach(var batchResult in ((ITimeSpanListtime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 1822372806, 1163976504))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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
                await foreach(var batchResult in ((ITimeSpanListtime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 1558222350, 575838185))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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
COPY public.binary_timespantime_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2MI),
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
FROM public.binary_timespantime_without_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2MI),
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

                var importCollection = new List<TimeSpantime_without_time_zoneArray2MI>(7);

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 140991566,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 144283911,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 228769667,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 250950821,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 439230713,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1041215353,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1072490419,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140991566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(144283911));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(228769667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(250950821));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(439230713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

};
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
                Assert.That(model.Id, Is.EqualTo(1041215353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

};
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
                Assert.That(model.Id, Is.EqualTo(1072490419));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1359375871,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1407946917,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1463896761,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1557342830,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1876000264,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 1997921769,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 2065242575,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2MI
                {
                    Id = 2093407547,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140991566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(144283911));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(228769667));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(250950821));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(439230713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

};
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
                Assert.That(model.Id, Is.EqualTo(1041215353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

};
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
                Assert.That(model.Id, Is.EqualTo(1072490419));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(1359375871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(1407946917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1463896761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1557342830));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876000264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(1997921769));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(2065242575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(2093407547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
COPY public.binary_timespantime_without_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespantime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
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
FROM public.binary_timespantime_without_time_zonearray2m m
LEFT JOIN public.binary_timespantime_without_time_zonearray2mi mi ON mi.id = m.timespantime_without_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
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

                var importCollection = new List<TimeSpantime_without_time_zoneArray2M>(15);

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 74780407,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1407946917
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 278043003,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 318059118,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 432621887,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 460205827,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 228769667
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 526720790,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 575838185,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1463896761
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 617407514,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 618758011,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1557342830
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 637902018,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 144283911
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 685753948,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1072490419
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 717416002,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 250950821
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 721265519,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1359375871
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 824843026,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 898152788,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 2065242575
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 898520110,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 933025369,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1041215353
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1163976504,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1257229835,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1285290855,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1997921769
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1341347086,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1490270908,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 140991566
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1558222350,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1599056800,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 439230713
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1822372806,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1903315673,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 1951249296,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 1876000264
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 2066743975,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray2MI 
                    {
                        Id = 2093407547
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 2075624424,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray2M
                {
                    Id = 2143132353,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74780407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407946917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

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
                Assert.That(model.Id, Is.EqualTo(278043003));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

};
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
                Assert.That(model.Id, Is.EqualTo(318059118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

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
                Assert.That(model.Id, Is.EqualTo(432621887));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

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
                Assert.That(model.Id, Is.EqualTo(460205827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(228769667));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526720790));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

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
                Assert.That(model.Id, Is.EqualTo(575838185));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463896761));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

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
                Assert.That(model.Id, Is.EqualTo(617407514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(618758011));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557342830));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

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
                Assert.That(model.Id, Is.EqualTo(637902018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(144283911));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

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
                Assert.That(model.Id, Is.EqualTo(685753948));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1072490419));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

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
                Assert.That(model.Id, Is.EqualTo(717416002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(250950821));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

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
                Assert.That(model.Id, Is.EqualTo(721265519));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1359375871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

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
                Assert.That(model.Id, Is.EqualTo(824843026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

};
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
                Assert.That(model.Id, Is.EqualTo(898152788));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2065242575));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

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
                Assert.That(model.Id, Is.EqualTo(898520110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

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
                Assert.That(model.Id, Is.EqualTo(933025369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041215353));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

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


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1163976504));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

};
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
                Assert.That(model.Id, Is.EqualTo(1257229835));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(1285290855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1997921769));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

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
                Assert.That(model.Id, Is.EqualTo(1341347086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

};
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
                Assert.That(model.Id, Is.EqualTo(1490270908));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(140991566));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

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
                Assert.That(model.Id, Is.EqualTo(1558222350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

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
                Assert.That(model.Id, Is.EqualTo(1599056800));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(439230713));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

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
                Assert.That(model.Id, Is.EqualTo(1822372806));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

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


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903315673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

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
                Assert.That(model.Id, Is.EqualTo(1951249296));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876000264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2066743975));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2093407547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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
                Assert.That(model.Id, Is.EqualTo(2075624424));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143132353));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

};
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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespantime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2M),
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

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray2M>(30);

                expected.Add(
                    74780407,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 74780407,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1407946917,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

}
                        }

                    }
                );

                expected.Add(
                    278043003,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 278043003,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    318059118,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 318059118,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    432621887,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 432621887,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    460205827,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 460205827,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 228769667,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

}
                        }

                    }
                );

                expected.Add(
                    526720790,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 526720790,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    575838185,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 575838185,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1463896761,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    617407514,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 617407514,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    618758011,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 618758011,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1557342830,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    637902018,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 637902018,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 144283911,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

}
                        }

                    }
                );

                expected.Add(
                    685753948,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 685753948,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1072490419,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

}
                        }

                    }
                );

                expected.Add(
                    717416002,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 717416002,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 250950821,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

}
                        }

                    }
                );

                expected.Add(
                    721265519,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 721265519,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1359375871,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

}
                        }

                    }
                );

                expected.Add(
                    824843026,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 824843026,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    898152788,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 898152788,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 2065242575,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

}
                        }

                    }
                );

                expected.Add(
                    898520110,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 898520110,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    933025369,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 933025369,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1041215353,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1163976504,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1163976504,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1257229835,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1257229835,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1285290855,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1285290855,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1997921769,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

}
                        }

                    }
                );

                expected.Add(
                    1341347086,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1341347086,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1490270908,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1490270908,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 140991566,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

}
                        }

                    }
                );

                expected.Add(
                    1558222350,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1558222350,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1599056800,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1599056800,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 439230713,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1822372806,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1822372806,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1903315673,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1903315673,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1951249296,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1951249296,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1876000264,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

}
                        }

                    }
                );

                expected.Add(
                    2066743975,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2066743975,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 2093407547,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

}
                        }

                    }
                );

                expected.Add(
                    2075624424,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2075624424,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2143132353,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2143132353,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

},
                        NullableValue = null,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
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

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray2M>(30);

                expected.Add(
                    74780407,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 74780407,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 32, milliseconds: 331),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 25, milliseconds: 392),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1407946917,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

}
                        }

                    }
                );

                expected.Add(
                    278043003,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 278043003,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 3, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 8, milliseconds: 548),

new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 3, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 463),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    318059118,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 318059118,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 42, milliseconds: 746),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 6, milliseconds: 763),

new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 33, milliseconds: 810),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 398),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 15, milliseconds: 576),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 30, milliseconds: 708),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 8, milliseconds: 804),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    432621887,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 432621887,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 0, milliseconds: 982),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 0, milliseconds: 552),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 116),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 46, milliseconds: 858),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 18, milliseconds: 604),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 736),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 34, milliseconds: 476),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    460205827,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 460205827,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 37, milliseconds: 996),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 58, milliseconds: 325),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 779),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 12, milliseconds: 921),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 52, milliseconds: 973),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 8, milliseconds: 998),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 27, milliseconds: 739),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 44, milliseconds: 373),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 228769667,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

}
                        }

                    }
                );

                expected.Add(
                    526720790,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 526720790,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 32, milliseconds: 282),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 5, milliseconds: 707),

new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 7, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 41, milliseconds: 775),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 11, milliseconds: 993),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 17, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 1, milliseconds: 625),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    575838185,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 575838185,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 39, milliseconds: 597),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 17, milliseconds: 976),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 50, milliseconds: 476),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1463896761,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    617407514,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 617407514,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 9, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 43, milliseconds: 350),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 52, milliseconds: 586),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 33, milliseconds: 990),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 18, milliseconds: 753),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 35, milliseconds: 338),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 4, milliseconds: 42),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 58, milliseconds: 604),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    618758011,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 618758011,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 58, milliseconds: 820),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 27, milliseconds: 936),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 35, milliseconds: 921),

new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 53, milliseconds: 847),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1557342830,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    637902018,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 637902018,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 59),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 5, milliseconds: 267),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 37, milliseconds: 990),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 42, milliseconds: 590),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 3, milliseconds: 271),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 39, milliseconds: 549),

new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 17, milliseconds: 995),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 31, milliseconds: 359),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 144283911,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

}
                        }

                    }
                );

                expected.Add(
                    685753948,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 685753948,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 10, milliseconds: 501),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 43, milliseconds: 770),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 29, milliseconds: 475),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 54, milliseconds: 988),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 465),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 49, milliseconds: 944),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1072490419,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

}
                        }

                    }
                );

                expected.Add(
                    717416002,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 717416002,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 577),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 7, milliseconds: 148),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 250950821,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

}
                        }

                    }
                );

                expected.Add(
                    721265519,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 721265519,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 49, milliseconds: 686),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 232),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 10, milliseconds: 829),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1359375871,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

}
                        }

                    }
                );

                expected.Add(
                    824843026,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 824843026,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 56, milliseconds: 783),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 2, milliseconds: 446),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 6, milliseconds: 187),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    898152788,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 898152788,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 29, milliseconds: 111),

new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 51, milliseconds: 480),

new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 0, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 26, milliseconds: 582),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 2065242575,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

}
                        }

                    }
                );

                expected.Add(
                    898520110,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 898520110,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 19, milliseconds: 994),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 6, milliseconds: 345),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 605),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 54, milliseconds: 358),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 18, milliseconds: 495),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 688),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 57, milliseconds: 317),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    933025369,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 933025369,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 33, milliseconds: 527),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 55, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 181),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1041215353,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1163976504,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1163976504,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 39, milliseconds: 357),

new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 8, milliseconds: 793),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 30, milliseconds: 270),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1257229835,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1257229835,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 42, milliseconds: 541),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 755),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 37, milliseconds: 860),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 30, milliseconds: 45),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 50, milliseconds: 729),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 20, milliseconds: 69),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1285290855,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1285290855,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 32),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 9, milliseconds: 221),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 20, milliseconds: 865),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 38, milliseconds: 50),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1997921769,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

}
                        }

                    }
                );

                expected.Add(
                    1341347086,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1341347086,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 39, milliseconds: 86),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 46, milliseconds: 920),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 52, milliseconds: 117),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 27, milliseconds: 377),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1490270908,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1490270908,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 26, milliseconds: 36),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 869),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 45, milliseconds: 470),

new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 25, milliseconds: 736),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 50, milliseconds: 187),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 140991566,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

}
                        }

                    }
                );

                expected.Add(
                    1558222350,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1558222350,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 35, milliseconds: 370),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 10, milliseconds: 794),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 25, milliseconds: 607),

new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 35, milliseconds: 439),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 23, milliseconds: 142),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 35, milliseconds: 184),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 54, milliseconds: 242),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 45, milliseconds: 621),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1599056800,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1599056800,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 28, milliseconds: 750),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 57, milliseconds: 703),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 16, milliseconds: 958),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 52, milliseconds: 956),

new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 12, milliseconds: 985),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 51, milliseconds: 909),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 439230713,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1822372806,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1822372806,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 31, milliseconds: 500),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 29, milliseconds: 484),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 39, milliseconds: 985),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 36, milliseconds: 42),

new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 834),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 51, milliseconds: 996),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1903315673,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1903315673,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 12, milliseconds: 426),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 11, milliseconds: 719),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 2, milliseconds: 584),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 19, milliseconds: 587),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 18, milliseconds: 134),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 57, milliseconds: 418),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 0, milliseconds: 571),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 1, milliseconds: 428),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1951249296,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 1951249296,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 48, milliseconds: 93),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 56, milliseconds: 186),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 10, milliseconds: 764),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 46, milliseconds: 125),

new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 22, milliseconds: 495),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 1876000264,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

}
                        }

                    }
                );

                expected.Add(
                    2066743975,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2066743975,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 26, milliseconds: 877),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 49, milliseconds: 282),

new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 39, milliseconds: 300),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 58, milliseconds: 296),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray2MI
                        {
                            Id = 2093407547,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

}
                        }

                    }
                );

                expected.Add(
                    2075624424,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2075624424,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 49, milliseconds: 285),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 30, milliseconds: 656),

new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 3, milliseconds: 940),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 16),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 41, milliseconds: 441),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 51, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 1, milliseconds: 536),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2143132353,
                    new TimeSpantime_without_time_zoneArray2M
                    {
                        Id = 2143132353,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 36, milliseconds: 210),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 18, milliseconds: 542),

new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 175),

},
                        NullableValue = null,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray2MI),
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

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray2MI>(15);

                expected.Add(
                    140991566,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 140991566,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

}
                    }
                );

                expected.Add(
                    144283911,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 144283911,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

}
                    }
                );

                expected.Add(
                    228769667,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 228769667,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

}
                    }
                );

                expected.Add(
                    250950821,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 250950821,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

}
                    }
                );

                expected.Add(
                    439230713,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 439230713,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1041215353,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1041215353,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1072490419,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1072490419,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

}
                    }
                );

                expected.Add(
                    1359375871,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1359375871,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

}
                    }
                );

                expected.Add(
                    1407946917,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1407946917,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

}
                    }
                );

                expected.Add(
                    1463896761,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1463896761,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1557342830,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1557342830,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1876000264,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1876000264,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

}
                    }
                );

                expected.Add(
                    1997921769,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1997921769,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

}
                    }
                );

                expected.Add(
                    2065242575,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 2065242575,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

}
                    }
                );

                expected.Add(
                    2093407547,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 2093407547,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray2MI>(15);

                expected.Add(
                    140991566,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 140991566,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 15, milliseconds: 820),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 16, milliseconds: 49),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 58, milliseconds: 109),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 46, milliseconds: 900),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 48, milliseconds: 42),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 16, milliseconds: 449),

new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 10, milliseconds: 855),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 16, milliseconds: 416),

}
                    }
                );

                expected.Add(
                    144283911,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 144283911,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 53, milliseconds: 516),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 42, milliseconds: 126),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 26, milliseconds: 221),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 53, milliseconds: 581),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 51, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 3, milliseconds: 19),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 10, milliseconds: 208),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 20, milliseconds: 498),

}
                    }
                );

                expected.Add(
                    228769667,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 228769667,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 56, milliseconds: 769),

new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 26, milliseconds: 644),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 14, milliseconds: 841),

new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 40, milliseconds: 934),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 41, milliseconds: 380),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 23, milliseconds: 497),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 54, milliseconds: 236),

}
                    }
                );

                expected.Add(
                    250950821,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 250950821,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 32, milliseconds: 863),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 35, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 26, milliseconds: 364),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 17, milliseconds: 997),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 13, milliseconds: 167),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 9, milliseconds: 947),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 486),

}
                    }
                );

                expected.Add(
                    439230713,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 439230713,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 42, milliseconds: 142),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 9, milliseconds: 865),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 780),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 12, milliseconds: 668),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1041215353,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1041215353,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 512),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 5, milliseconds: 861),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 26, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 30, milliseconds: 517),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1072490419,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1072490419,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 979),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 47, milliseconds: 45),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 55, milliseconds: 573),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 56, milliseconds: 684),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 26, milliseconds: 934),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 38, milliseconds: 62),

}
                    }
                );

                expected.Add(
                    1359375871,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1359375871,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 20, milliseconds: 406),

new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 296),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 34, milliseconds: 723),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 20, milliseconds: 166),

new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 55, milliseconds: 718),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 39, milliseconds: 604),

}
                    }
                );

                expected.Add(
                    1407946917,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1407946917,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 43, milliseconds: 626),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 26, milliseconds: 870),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 20, milliseconds: 803),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 36, milliseconds: 46),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 39, milliseconds: 900),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 8, milliseconds: 318),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 16, milliseconds: 818),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 38, milliseconds: 932),

}
                    }
                );

                expected.Add(
                    1463896761,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1463896761,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 13, milliseconds: 844),

new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 28, milliseconds: 355),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 327),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 22, milliseconds: 124),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1557342830,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1557342830,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 36, milliseconds: 264),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 35, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 39, milliseconds: 503),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 3, milliseconds: 110),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1876000264,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1876000264,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 14, milliseconds: 838),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 34, milliseconds: 22),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 38, milliseconds: 764),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 998),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 28, milliseconds: 891),

}
                    }
                );

                expected.Add(
                    1997921769,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 1997921769,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 31, milliseconds: 652),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 5, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 50, milliseconds: 808),

new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 13, milliseconds: 379),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 40, milliseconds: 667),

new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 39, milliseconds: 155),

new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 32, milliseconds: 456),

}
                    }
                );

                expected.Add(
                    2065242575,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 2065242575,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 13, milliseconds: 147),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 41, milliseconds: 634),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 0, milliseconds: 727),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 101),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 26, milliseconds: 772),

new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 30),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 45, milliseconds: 635),

}
                    }
                );

                expected.Add(
                    2093407547,
                    new TimeSpantime_without_time_zoneArray2MI
                    {
                        Id = 2093407547,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 14, milliseconds: 530),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 55, milliseconds: 231),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 23, milliseconds: 866),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 3, milliseconds: 945),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 5, milliseconds: 882),

new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 8, milliseconds: 981),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 42, milliseconds: 220),

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


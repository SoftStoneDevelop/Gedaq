

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
    internal partial interface IDateTimeListtimestamp_with_time_zoneArray
    {
    }
    
    internal partial class DateTimeListtimestamp_with_time_zoneArray : IDateTimeListtimestamp_with_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2mi(
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2mi(
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
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInner(connection, 517561414, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInner(connection, 1886371614, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, 92381456, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, 998716332, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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

                id =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, 1340802427, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(1340802427));

                id =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, 1545606475, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1545606475));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2124351443, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(2124351443));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1137198080, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1137198080));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1257101921, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(1257101921));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 724907026, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(724907026));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 626523687, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(626523687));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 684519556, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(684519556));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 42205478, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(42205478));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 50140876, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(50140876));

                id = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 873157096, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(873157096));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray2mi_id
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
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray2mi_id", 
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

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModel(connection, 1113870877, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModel(connection, 1202819028, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

}, 517561414);
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

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelAsync(connection, 1723548880, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelAsync(connection, 1530046511, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

}, 1886371614);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray2m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray2mi_id
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
    datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateTime>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray2mi_id", 
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
                List<DateTimetimestamp_with_time_zoneArray2M> models = null;
                DateTimetimestamp_with_time_zoneArray2M model = null;

                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 699255808, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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

                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 1256102093, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

}, 92381456).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 861134693, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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

                models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 1988469787, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

}, 998716332).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneArray2M> models = null;
                DateTimetimestamp_with_time_zoneArray2M model = null;

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 452846999, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 2143733874, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

}, null, 1340802427).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 912210571, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1525189923, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

}, null, 1545606475).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 432543798, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1005829104, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

}, 2124351443).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1996030281, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1234042654, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

}, null, 1137198080).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 550917042, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1927064732, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

}, null, 1257101921).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1449475158, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 845455057, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

}, null, 724907026).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1082221086, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1197914253, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

}, null, 626523687).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 860724339, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1795114341, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

}, 684519556).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 2015065969, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 661104708, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

}, 42205478).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 589843716, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1649969147, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

}, 50140876).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 855862484, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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

                models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 729912755, 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

}, 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

}, 873157096).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
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
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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
FROM public.datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
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
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 1449475158);
                var models =  ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeListtimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeListtimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 861134693);
                var models = await ((IDateTimeListtimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(19));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeListtimestamp_with_time_zoneArray)
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
                 foreach(var batchResult in ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 1996030281, 1005829104))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(17));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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
                await foreach(var batchResult in ((IDateTimeListtimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 1649969147, 661104708))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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
FROM public.binary_datetimetimestamp_with_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MI),
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

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2MI>(7);

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 42205478,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 50140876,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 92381456,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 517561414,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 626523687,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 684519556,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 724907026,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(42205478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(50140876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(92381456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(517561414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(626523687));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(684519556));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(724907026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

};
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
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 873157096,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 998716332,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 1137198080,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 1257101921,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 1340802427,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 1545606475,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 1886371614,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2MI
                {
                    Id = 2124351443,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(42205478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(50140876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(92381456));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(517561414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(626523687));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(684519556));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(724907026));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(873157096));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(998716332));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1137198080));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1257101921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1340802427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1545606475));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1886371614));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2124351443));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
COPY public.binary_datetimetimestamp_with_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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
FROM public.binary_datetimetimestamp_with_time_zonearray2m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zonearray2mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
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

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray2M>(15);

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 432543798,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 452846999,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 550917042,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 589843716,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 661104708,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 42205478
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 699255808,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 729912755,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 873157096
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 845455057,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 724907026
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 855862484,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 860724339,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 861134693,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 912210571,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1005829104,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 2124351443
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1082221086,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1113870877,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1197914253,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 626523687
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1202819028,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 517561414
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1234042654,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 1137198080
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1256102093,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 92381456
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1449475158,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1525189923,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 1545606475
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1530046511,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 1886371614
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1649969147,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 50140876
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1723548880,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1795114341,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 684519556
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1927064732,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 1257101921
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1988469787,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 998716332
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 1996030281,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 2015065969,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray2M
                {
                    Id = 2143733874,
                    Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray2MI 
                    {
                        Id = 1340802427
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432543798));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(452846999));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(550917042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(589843716));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(661104708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(42205478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(699255808));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(729912755));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(873157096));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(845455057));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(724907026));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(855862484));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(860724339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(861134693));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(912210571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1005829104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2124351443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1082221086));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1113870877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1197914253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(626523687));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1202819028));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(517561414));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1234042654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1137198080));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1256102093));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(92381456));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1449475158));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1525189923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1545606475));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1530046511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886371614));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1649969147));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(50140876));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1723548880));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1795114341));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(684519556));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1927064732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1257101921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

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


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988469787));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(998716332));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

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
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1996030281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015065969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

};
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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2143733874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1340802427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray2M>(30);

                expected.Add(
                    432543798,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 432543798,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    452846999,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 452846999,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    550917042,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 550917042,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    589843716,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 589843716,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    661104708,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 661104708,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 42205478,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    699255808,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 699255808,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    729912755,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 729912755,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 873157096,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    845455057,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 845455057,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 724907026,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    855862484,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 855862484,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    860724339,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 860724339,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    861134693,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 861134693,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    912210571,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 912210571,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1005829104,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1005829104,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 2124351443,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1082221086,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1082221086,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1113870877,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1113870877,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197914253,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1197914253,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 626523687,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1202819028,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1202819028,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 517561414,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1234042654,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1234042654,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1137198080,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1256102093,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1256102093,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 92381456,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1449475158,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1449475158,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1525189923,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1525189923,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1545606475,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1530046511,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1530046511,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1886371614,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1649969147,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1649969147,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 50140876,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1723548880,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1723548880,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1795114341,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1795114341,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 684519556,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1927064732,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1927064732,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1257101921,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1988469787,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1988469787,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 998716332,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1996030281,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1996030281,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2015065969,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 2015065969,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2143733874,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 2143733874,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1340802427,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray2M>(30);

                expected.Add(
                    432543798,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 432543798,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1936, month: 10, day: 11, hour: 20, minute: 37, second: 32, millisecond: 898, kind: DateTimeKind.Utc),

new DateTime(year: 2010, month: 10, day: 11, hour: 10, minute: 42, second: 45, millisecond: 620, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 43, second: 38, millisecond: 391, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 4, hour: 4, minute: 7, second: 39, millisecond: 329, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 12, hour: 22, minute: 51, second: 5, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 7, hour: 18, minute: 56, second: 2, millisecond: 237, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 12, hour: 13, minute: 6, second: 4, millisecond: 604, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    452846999,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 452846999,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2012, month: 10, day: 9, hour: 4, minute: 33, second: 9, millisecond: 211, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 12, hour: 2, minute: 45, second: 7, millisecond: 666, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 5, minute: 33, second: 12, millisecond: 796, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 16, minute: 23, second: 50, millisecond: 559, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1952, month: 10, day: 18, hour: 6, minute: 46, second: 5, millisecond: 475, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 3, hour: 3, minute: 45, second: 38, millisecond: 404, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 15, hour: 2, minute: 4, second: 14, millisecond: 556, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    550917042,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 550917042,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1935, month: 10, day: 8, hour: 14, minute: 52, second: 8, millisecond: 907, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 8, hour: 11, minute: 27, second: 53, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 18, second: 48, millisecond: 805, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    589843716,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 589843716,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 11, minute: 29, second: 25, millisecond: 377, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 6, hour: 12, minute: 22, second: 47, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 16, minute: 9, second: 2, millisecond: 894, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2019, month: 10, day: 14, hour: 3, minute: 16, second: 39, millisecond: 196, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 14, hour: 8, minute: 9, second: 28, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 6, hour: 19, minute: 11, second: 3, millisecond: 606, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    661104708,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 661104708,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2015, month: 10, day: 16, hour: 3, minute: 36, second: 8, millisecond: 364, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 7, hour: 1, minute: 18, second: 47, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 16, hour: 10, minute: 37, second: 49, millisecond: 543, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 1, hour: 11, minute: 56, second: 47, millisecond: 435, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1972, month: 10, day: 4, hour: 8, minute: 18, second: 37, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 5, hour: 10, minute: 17, second: 18, millisecond: 277, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 9, hour: 22, minute: 24, second: 11, millisecond: 689, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 2, hour: 17, minute: 55, second: 26, millisecond: 238, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 42205478,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    699255808,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 699255808,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1940, month: 10, day: 18, hour: 16, minute: 11, second: 31, millisecond: 57, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 16, hour: 11, minute: 48, second: 29, millisecond: 96, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 20, minute: 24, second: 29, millisecond: 603, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1985, month: 10, day: 9, hour: 21, minute: 20, second: 15, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 3, second: 25, millisecond: 770, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 14, minute: 1, second: 36, millisecond: 448, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    729912755,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 729912755,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 6, hour: 6, minute: 45, second: 5, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 11, minute: 19, second: 2, millisecond: 586, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 11, hour: 8, minute: 24, second: 11, millisecond: 332, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1954, month: 10, day: 11, hour: 3, minute: 42, second: 18, millisecond: 60, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 4, hour: 12, minute: 23, second: 3, millisecond: 929, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 2, hour: 20, minute: 19, second: 37, millisecond: 805, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 19, hour: 3, minute: 58, second: 47, millisecond: 500, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 873157096,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    845455057,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 845455057,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1923, month: 10, day: 11, hour: 15, minute: 29, second: 6, millisecond: 206, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 13, hour: 22, minute: 50, second: 41, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 10, hour: 22, minute: 53, second: 15, millisecond: 527, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 6, hour: 2, minute: 58, second: 52, millisecond: 681, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 724907026,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    855862484,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 855862484,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1962, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 272, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 19, hour: 3, minute: 33, second: 58, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 5, hour: 15, minute: 28, second: 6, millisecond: 262, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 11, hour: 18, minute: 15, second: 40, millisecond: 402, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 19, hour: 8, minute: 47, second: 36, millisecond: 177, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 2, minute: 33, second: 17, millisecond: 707, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 8, hour: 7, minute: 20, second: 17, millisecond: 782, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    860724339,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 860724339,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1996, month: 10, day: 17, hour: 13, minute: 47, second: 7, millisecond: 298, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 1, hour: 12, minute: 48, second: 28, millisecond: 289, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 2, hour: 14, minute: 33, second: 19, millisecond: 394, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 14, hour: 22, minute: 45, second: 52, millisecond: 439, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    861134693,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 861134693,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 8, hour: 14, minute: 58, second: 45, millisecond: 969, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 5, hour: 15, minute: 50, second: 24, millisecond: 245, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 14, hour: 10, minute: 57, second: 47, millisecond: 396, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    912210571,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 912210571,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 17, hour: 10, minute: 30, second: 39, millisecond: 465, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 1, hour: 11, minute: 15, second: 15, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 15, hour: 8, minute: 7, second: 32, millisecond: 967, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1988, month: 10, day: 6, hour: 7, minute: 3, second: 24, millisecond: 492, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 18, hour: 4, minute: 56, second: 43, millisecond: 899, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 10, hour: 18, minute: 10, second: 15, millisecond: 249, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 8, hour: 10, minute: 34, second: 8, millisecond: 376, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1005829104,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1005829104,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1973, month: 10, day: 19, hour: 21, minute: 44, second: 37, millisecond: 864, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 8, hour: 18, minute: 31, second: 34, millisecond: 403, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 18, second: 43, millisecond: 156, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 7, hour: 19, minute: 53, second: 29, millisecond: 12, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1961, month: 10, day: 3, hour: 16, minute: 15, second: 9, millisecond: 821, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 6, hour: 12, minute: 12, second: 12, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 7, hour: 2, minute: 56, second: 52, millisecond: 450, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 2124351443,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1082221086,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1082221086,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1925, month: 10, day: 12, hour: 12, minute: 55, second: 30, millisecond: 769, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 18, hour: 20, minute: 25, second: 43, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 8, hour: 12, minute: 51, second: 30, millisecond: 883, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 8, hour: 8, minute: 39, second: 49, millisecond: 787, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2006, month: 10, day: 19, hour: 6, minute: 33, second: 56, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 18, hour: 22, minute: 48, second: 39, millisecond: 861, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 17, hour: 15, minute: 3, second: 36, millisecond: 343, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 2, hour: 6, minute: 5, second: 6, millisecond: 744, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1113870877,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1113870877,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1970, month: 10, day: 5, hour: 6, minute: 19, second: 47, millisecond: 322, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 17, hour: 13, minute: 27, second: 14, millisecond: 803, kind: DateTimeKind.Utc),

new DateTime(year: 1943, month: 10, day: 17, hour: 16, minute: 46, second: 6, millisecond: 748, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 3, hour: 8, minute: 18, second: 57, millisecond: 876, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 5, hour: 20, minute: 8, second: 49, millisecond: 604, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 19, hour: 2, minute: 58, second: 19, millisecond: 599, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197914253,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1197914253,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1919, month: 10, day: 6, hour: 1, minute: 44, second: 20, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 13, hour: 3, minute: 21, second: 36, millisecond: 119, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 16, hour: 15, minute: 53, second: 28, millisecond: 270, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 626523687,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1202819028,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1202819028,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1998, month: 10, day: 5, hour: 22, minute: 43, second: 55, millisecond: 892, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 13, hour: 10, minute: 13, second: 3, millisecond: 810, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 11, second: 54, millisecond: 25, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 14, hour: 17, minute: 34, second: 40, millisecond: 442, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 1, minute: 28, second: 17, millisecond: 77, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 19, hour: 14, minute: 55, second: 37, millisecond: 431, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 517561414,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1234042654,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1234042654,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1917, month: 10, day: 4, hour: 6, minute: 8, second: 35, millisecond: 817, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 12, hour: 22, minute: 22, second: 50, millisecond: 542, kind: DateTimeKind.Utc),

new DateTime(year: 1994, month: 10, day: 12, hour: 11, minute: 44, second: 19, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 7, hour: 22, minute: 2, second: 7, millisecond: 140, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1137198080,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1256102093,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1256102093,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 7, hour: 9, minute: 37, second: 54, millisecond: 736, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 9, hour: 18, minute: 6, second: 48, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 5, hour: 10, minute: 28, second: 42, millisecond: 365, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 16, minute: 47, second: 42, millisecond: 829, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 5, hour: 16, minute: 34, second: 55, millisecond: 757, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 5, hour: 18, minute: 4, second: 44, millisecond: 680, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 92381456,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1449475158,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1449475158,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1990, month: 10, day: 1, hour: 10, minute: 33, second: 2, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 17, hour: 8, minute: 41, second: 11, millisecond: 585, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 19, hour: 13, minute: 54, second: 40, millisecond: 710, kind: DateTimeKind.Utc),

new DateTime(year: 1976, month: 10, day: 12, hour: 7, minute: 12, second: 12, millisecond: 640, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1525189923,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1525189923,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1955, month: 10, day: 14, hour: 14, minute: 42, second: 52, millisecond: 488, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 4, hour: 13, minute: 49, second: 56, millisecond: 98, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 14, hour: 5, minute: 46, second: 37, millisecond: 482, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1545606475,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1530046511,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1530046511,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1968, month: 10, day: 11, hour: 18, minute: 5, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 4, hour: 21, minute: 37, second: 34, millisecond: 630, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 14, hour: 12, minute: 7, second: 15, millisecond: 409, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2007, month: 10, day: 19, hour: 10, minute: 5, second: 11, millisecond: 161, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 15, hour: 17, minute: 34, second: 8, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1973, month: 10, day: 2, hour: 18, minute: 32, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1886371614,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1649969147,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1649969147,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1976, month: 10, day: 13, hour: 6, minute: 19, second: 37, millisecond: 263, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 1, minute: 8, second: 26, millisecond: 169, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 5, hour: 19, minute: 14, second: 44, millisecond: 283, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1972, month: 10, day: 19, hour: 8, minute: 26, second: 33, millisecond: 274, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 6, hour: 22, minute: 4, second: 47, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 4, hour: 16, minute: 58, second: 14, millisecond: 806, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 50140876,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1723548880,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1723548880,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 5, hour: 2, minute: 9, second: 14, millisecond: 283, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 2, hour: 2, minute: 54, second: 10, millisecond: 12, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 12, hour: 3, minute: 7, second: 27, millisecond: 498, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 5, hour: 17, minute: 31, second: 13, millisecond: 319, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1795114341,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1795114341,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1980, month: 10, day: 6, hour: 22, minute: 9, second: 9, millisecond: 836, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 9, hour: 22, minute: 51, second: 27, millisecond: 454, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 6, hour: 22, minute: 18, second: 49, millisecond: 354, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1939, month: 10, day: 9, hour: 13, minute: 8, second: 5, millisecond: 286, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 12, hour: 6, minute: 27, second: 47, millisecond: 422, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 15, hour: 15, minute: 19, second: 44, millisecond: 902, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 9, hour: 13, minute: 6, second: 9, millisecond: 262, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 684519556,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1927064732,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1927064732,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1995, month: 10, day: 4, hour: 19, minute: 52, second: 14, millisecond: 341, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 11, hour: 8, minute: 47, second: 22, millisecond: 581, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 7, minute: 32, second: 20, millisecond: 312, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1257101921,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1988469787,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1988469787,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1979, month: 10, day: 3, hour: 5, minute: 4, second: 23, millisecond: 667, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 9, hour: 12, minute: 58, second: 30, millisecond: 36, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 4, hour: 20, minute: 32, second: 6, millisecond: 983, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 16, hour: 4, minute: 36, second: 24, millisecond: 27, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1996, month: 10, day: 16, hour: 19, minute: 49, second: 42, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 6, hour: 18, minute: 39, second: 46, millisecond: 198, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 9, hour: 20, minute: 21, second: 4, millisecond: 958, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 998716332,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1996030281,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 1996030281,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1958, month: 10, day: 19, hour: 3, minute: 38, second: 35, millisecond: 424, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 1, hour: 7, minute: 25, second: 11, millisecond: 932, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 17, hour: 7, minute: 47, second: 3, millisecond: 233, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2019, month: 10, day: 11, hour: 1, minute: 10, second: 3, millisecond: 399, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 1, hour: 3, minute: 4, second: 40, millisecond: 648, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 9, minute: 6, second: 44, millisecond: 510, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 16, hour: 18, minute: 42, second: 2, millisecond: 122, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2015065969,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 2015065969,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1926, month: 10, day: 3, hour: 21, minute: 14, second: 6, millisecond: 212, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 6, hour: 7, minute: 26, second: 27, millisecond: 223, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 8, hour: 6, minute: 21, second: 9, millisecond: 563, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2143733874,
                    new DateTimetimestamp_with_time_zoneArray2M
                    {
                        Id = 2143733874,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 14, minute: 8, second: 44, millisecond: 4, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 4, hour: 4, minute: 45, second: 54, millisecond: 814, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 17, hour: 17, minute: 33, second: 34, millisecond: 104, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 18, hour: 21, minute: 20, second: 47, millisecond: 665, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray2MI
                        {
                            Id = 1340802427,
                            Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateTime>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622),
                (NpgsqlTypes.NpgsqlDbType)(-2147483622)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray2MI>(15);

                expected.Add(
                    42205478,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 42205478,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    50140876,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 50140876,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    92381456,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 92381456,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    517561414,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 517561414,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    626523687,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 626523687,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    684519556,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 684519556,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    724907026,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 724907026,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    873157096,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 873157096,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    998716332,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 998716332,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1137198080,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1137198080,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1257101921,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1257101921,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1340802427,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1340802427,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1545606475,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1545606475,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1886371614,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1886371614,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    2124351443,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 2124351443,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray2MI>(15);

                expected.Add(
                    42205478,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 42205478,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1939, month: 10, day: 18, hour: 2, minute: 42, second: 3, millisecond: 642, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 2, hour: 12, minute: 4, second: 23, millisecond: 243, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 10, hour: 9, minute: 27, second: 36, millisecond: 38, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1960, month: 10, day: 8, hour: 8, minute: 18, second: 37, millisecond: 728, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 2, hour: 1, minute: 41, second: 55, millisecond: 755, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 3, hour: 12, minute: 2, second: 52, millisecond: 452, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    50140876,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 50140876,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1951, month: 10, day: 2, hour: 18, minute: 23, second: 45, millisecond: 782, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 17, hour: 21, minute: 20, second: 12, millisecond: 549, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 3, hour: 15, minute: 48, second: 26, millisecond: 498, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    92381456,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 92381456,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 32, second: 16, millisecond: 409, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 18, hour: 11, minute: 19, second: 50, millisecond: 258, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 19, hour: 6, minute: 53, second: 25, millisecond: 54, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 15, hour: 11, minute: 4, second: 29, millisecond: 206, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    517561414,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 517561414,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 58, second: 19, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 4, hour: 4, minute: 57, second: 41, millisecond: 709, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 10, hour: 11, minute: 38, second: 25, millisecond: 338, kind: DateTimeKind.Utc),

new DateTime(year: 1972, month: 10, day: 10, hour: 16, minute: 12, second: 39, millisecond: 332, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    626523687,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 626523687,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 2015, month: 10, day: 18, hour: 3, minute: 32, second: 33, millisecond: 644, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 19, hour: 20, minute: 48, second: 48, millisecond: 966, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 12, hour: 20, minute: 40, second: 34, millisecond: 168, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2007, month: 10, day: 2, hour: 6, minute: 4, second: 27, millisecond: 942, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 7, hour: 5, minute: 4, second: 24, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 12, hour: 19, minute: 52, second: 19, millisecond: 430, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 3, hour: 5, minute: 5, second: 30, millisecond: 558, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    684519556,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 684519556,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2009, month: 10, day: 16, hour: 1, minute: 50, second: 49, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 12, hour: 5, minute: 23, second: 23, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1990, month: 10, day: 7, hour: 3, minute: 44, second: 17, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 32, second: 29, millisecond: 713, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    724907026,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 724907026,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1941, month: 10, day: 19, hour: 1, minute: 46, second: 17, millisecond: 601, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 13, hour: 22, minute: 20, second: 12, millisecond: 835, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 13, minute: 51, second: 11, millisecond: 134, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    873157096,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 873157096,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2005, month: 10, day: 14, hour: 5, minute: 47, second: 35, millisecond: 698, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 9, minute: 37, second: 50, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 1, hour: 10, minute: 5, second: 19, millisecond: 568, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 4, hour: 12, minute: 57, second: 30, millisecond: 460, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1969, month: 10, day: 11, hour: 8, minute: 29, second: 18, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 16, hour: 18, minute: 50, second: 44, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 12, hour: 17, minute: 33, second: 51, millisecond: 241, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    998716332,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 998716332,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 43, second: 43, millisecond: 934, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 13, hour: 10, minute: 17, second: 29, millisecond: 881, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 7, hour: 18, minute: 7, second: 8, millisecond: 846, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1979, month: 10, day: 11, hour: 5, minute: 48, second: 35, millisecond: 870, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 7, minute: 35, second: 11, millisecond: 295, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 11, hour: 14, minute: 28, second: 20, millisecond: 695, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1137198080,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1137198080,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1918, month: 10, day: 13, hour: 17, minute: 29, second: 1, millisecond: 147, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 7, hour: 19, minute: 23, second: 2, millisecond: 373, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 19, minute: 44, second: 57, millisecond: 317, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 4, hour: 16, minute: 36, second: 55, millisecond: 665, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1966, month: 10, day: 14, hour: 2, minute: 9, second: 35, millisecond: 523, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 1, hour: 9, minute: 54, second: 54, millisecond: 276, kind: DateTimeKind.Utc),

new DateTime(year: 1928, month: 10, day: 1, hour: 8, minute: 20, second: 9, millisecond: 114, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 13, hour: 14, minute: 54, second: 15, millisecond: 79, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1257101921,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1257101921,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1983, month: 10, day: 17, hour: 4, minute: 49, second: 25, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 13, hour: 3, minute: 3, second: 55, millisecond: 485, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 17, hour: 6, minute: 52, second: 18, millisecond: 602, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1340802427,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1340802427,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1928, month: 10, day: 19, hour: 14, minute: 3, second: 27, millisecond: 214, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 14, hour: 11, minute: 35, second: 33, millisecond: 194, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 2, hour: 16, minute: 58, second: 11, millisecond: 101, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 18, hour: 20, minute: 1, second: 38, millisecond: 466, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1545606475,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1545606475,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1933, month: 10, day: 1, hour: 14, minute: 45, second: 46, millisecond: 806, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 30, second: 36, millisecond: 514, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 15, hour: 2, minute: 32, second: 6, millisecond: 89, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1978, month: 10, day: 13, hour: 21, minute: 19, second: 11, millisecond: 27, kind: DateTimeKind.Utc),

new DateTime(year: 2012, month: 10, day: 13, hour: 15, minute: 28, second: 22, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 18, hour: 7, minute: 41, second: 24, millisecond: 599, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 5, minute: 41, second: 30, millisecond: 424, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1886371614,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 1886371614,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 2017, month: 10, day: 19, hour: 9, minute: 38, second: 6, millisecond: 244, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 12, hour: 21, minute: 28, second: 26, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1923, month: 10, day: 19, hour: 9, minute: 16, second: 48, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 3, hour: 12, minute: 24, second: 58, millisecond: 11, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(3)
{
new DateTime(year: 1997, month: 10, day: 12, hour: 6, minute: 42, second: 17, millisecond: 525, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 10, hour: 18, minute: 44, second: 45, millisecond: 799, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 8, minute: 31, second: 58, millisecond: 272, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    2124351443,
                    new DateTimetimestamp_with_time_zoneArray2MI
                    {
                        Id = 2124351443,
                        Value = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1993, month: 10, day: 3, hour: 8, minute: 49, second: 5, millisecond: 412, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 14, minute: 19, second: 8, millisecond: 560, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 9, hour: 4, minute: 47, second: 20, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 2, minute: 21, second: 3, millisecond: 819, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateTime>(4)
{
new DateTime(year: 1956, month: 10, day: 9, hour: 16, minute: 18, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 12, hour: 17, minute: 15, second: 44, millisecond: 720, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 6, hour: 10, minute: 18, second: 34, millisecond: 480, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 17, hour: 2, minute: 21, second: 38, millisecond: 476, kind: DateTimeKind.Utc),

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




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
    internal partial interface IDateTimeArraytimestamp_with_time_zoneArray
    {
    }
    
    internal partial class DateTimeArraytimestamp_with_time_zoneArray : IDateTimeArraytimestamp_with_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1mi(
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
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
INSERT INTO public.datetimetimestamp_with_time_zonearray1mi(
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
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
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

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInner(connection, 74430180, 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInner(connection, 1805809628, 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, 1757018207, 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerAsync(connection, 262025274, 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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

                id =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, 393038928, 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(393038928));

                id =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturning(connection, 1905334939, 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1905334939));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 90766009, 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(90766009));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2140239296, 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(2140239296));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1990053873, 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(1990053873));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1192876633, 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1192876633));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1913431385, 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1913431385));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2147096151, 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(2147096151));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2015278073, 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(2015278073));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 188249933, 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

}, null);
                Assert.That(id, Is.EqualTo(188249933));

                id = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1523137061, 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

});
                Assert.That(id, Is.EqualTo(1523137061));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray1mi_id
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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray1mi_id", 
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

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModel(connection, 758518699, 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModel(connection, 532471242, 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

}, null, 74430180);
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

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelAsync(connection, 2010990844, 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelAsync(connection, 1353665593, 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

}, null, 1805809628);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;

                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, 1880962063, 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

}));

                nullable =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturning(connection, 792961781, 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

}, 1757018207);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

}));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;

                nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 408443821, 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

}));

                nullable = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 1551152806, 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

}, null, 262025274);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zonearray1mi_id
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
    datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483622)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zonearray1mi_id", 
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
                List<DateTimetimestamp_with_time_zoneArray1M> models = null;
                DateTimetimestamp_with_time_zoneArray1M model = null;

                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 82935682, 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 1198128821, 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

}, 393038928).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 1190277834, 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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

                models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturning(connection, 502697571, 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

}, 1905334939).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zoneArray1M> models = null;
                DateTimetimestamp_with_time_zoneArray1M model = null;

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 55163052, 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 368908348, 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

}, 90766009).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 128722319, 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 983438495, 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

}, 2140239296).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 480725515, 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1776463757, 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

}, 1990053873).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1068669733, 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 2067662540, 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

}, 1192876633).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1026966012, 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1878827244, 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

}, 1913431385).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 143161968, 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 717236245, 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

}, null, 2147096151).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 390439175, 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 133629637, 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

}, 2015278073).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 222430106, 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1285347857, 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

}, 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

}, 188249933).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 1713607458, 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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

                models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).InsertModelReturningAsync(connection, 134103655, 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

}, 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

}, 1523137061).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
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
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
FROM public.datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
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
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                 using var cmd =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 133629637);
                var models =  ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                await using var cmd = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeArraytimestamp_with_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 1026966012);
                var models = await ((IDateTimeArraytimestamp_with_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(12));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
            asPartInterface: typeof(IDateTimeArraytimestamp_with_time_zoneArray)
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
                 foreach(var batchResult in ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 143161968, 1190277834))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                await foreach(var batchResult in ((IDateTimeArraytimestamp_with_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 1068669733, 1198128821))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MI),
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
FROM public.binary_datetimetimestamp_with_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MI),
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

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1MI>(7);

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 74430180,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 90766009,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 188249933,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 262025274,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 393038928,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1192876633,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1523137061,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74430180));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90766009));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(188249933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(262025274));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(393038928));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1192876633));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1523137061));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1757018207,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1805809628,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1905334939,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1913431385,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 1990053873,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 2015278073,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 2140239296,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

}
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1MI
                {
                    Id = 2147096151,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74430180));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90766009));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(188249933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(262025274));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(393038928));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1192876633));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1523137061));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1757018207));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1805809628));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1905334939));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1913431385));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1990053873));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2015278073));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2140239296));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(2147096151));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

};
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
COPY public.binary_datetimetimestamp_with_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
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
FROM public.binary_datetimetimestamp_with_time_zonearray1m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_with_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
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

                var importCollection = new List<DateTimetimestamp_with_time_zoneArray1M>(15);

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 55163052,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 82935682,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 128722319,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 133629637,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 2015278073
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 134103655,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1523137061
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 143161968,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 222430106,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 368908348,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 90766009
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 390439175,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 408443821,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 480725515,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 502697571,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1905334939
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 532471242,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 74430180
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 717236245,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 2147096151
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 758518699,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 792961781,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1757018207
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 983438495,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 2140239296
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1026966012,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1068669733,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1190277834,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1198128821,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 393038928
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1285347857,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 188249933
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1353665593,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1805809628
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1551152806,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 262025274
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1713607458,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1776463757,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1990053873
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1878827244,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1913431385
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 1880962063,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 2010990844,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zoneArray1M
                {
                    Id = 2067662540,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

},

                    ModelInner = new DateTimetimestamp_with_time_zoneArray1MI 
                    {
                        Id = 1192876633
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55163052));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(82935682));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(128722319));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(133629637));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2015278073));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(134103655));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523137061));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(143161968));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(222430106));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(368908348));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(90766009));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(390439175));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(408443821));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(480725515));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(502697571));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1905334939));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(532471242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(74430180));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(717236245));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2147096151));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(758518699));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(792961781));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1757018207));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(983438495));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2140239296));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1026966012));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1068669733));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1190277834));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1198128821));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(393038928));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1285347857));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(188249933));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1353665593));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805809628));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1551152806));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262025274));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1713607458));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(1776463757));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1990053873));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1878827244));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1913431385));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

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
                Assert.That(model.Id, Is.EqualTo(1880962063));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2010990844));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

};
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
                Assert.That(model.Id, Is.EqualTo(2067662540));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192876633));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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
COPY public.binary_datetimetimestamp_with_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1M),
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray1M>(30);

                expected.Add(
                    55163052,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 55163052,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    82935682,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 82935682,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    128722319,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 128722319,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    133629637,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 133629637,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2015278073,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    134103655,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 134103655,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1523137061,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    143161968,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 143161968,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    222430106,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 222430106,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    368908348,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 368908348,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 90766009,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    390439175,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 390439175,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    408443821,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 408443821,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    480725515,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 480725515,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    502697571,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 502697571,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1905334939,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    532471242,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 532471242,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 74430180,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    717236245,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 717236245,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2147096151,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    758518699,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 758518699,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    792961781,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 792961781,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1757018207,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    983438495,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 983438495,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2140239296,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1026966012,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1026966012,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1068669733,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1068669733,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1190277834,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1190277834,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198128821,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1198128821,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 393038928,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1285347857,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1285347857,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 188249933,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1353665593,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1353665593,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1805809628,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1551152806,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1551152806,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 262025274,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1713607458,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1713607458,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1776463757,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1776463757,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1990053873,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1878827244,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1878827244,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1913431385,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1880962063,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1880962063,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2010990844,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 2010990844,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2067662540,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 2067662540,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1192876633,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray1M>(30);

                expected.Add(
                    55163052,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 55163052,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 2, second: 55, millisecond: 291, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 21, minute: 3, second: 45, millisecond: 781, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 19, hour: 16, minute: 34, second: 56, millisecond: 758, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 2, hour: 2, minute: 24, second: 23, millisecond: 897, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 9, hour: 1, minute: 40, second: 58, millisecond: 398, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 12, hour: 1, minute: 25, second: 20, millisecond: 627, kind: DateTimeKind.Utc),

new DateTime(year: 1969, month: 10, day: 2, hour: 10, minute: 24, second: 23, millisecond: 73, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 3, hour: 13, minute: 19, second: 53, millisecond: 373, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    82935682,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 82935682,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1941, month: 10, day: 11, hour: 2, minute: 58, second: 34, millisecond: 95, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 12, minute: 31, second: 50, millisecond: 558, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 9, hour: 11, minute: 43, second: 28, millisecond: 760, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1962, month: 10, day: 19, hour: 22, minute: 27, second: 2, millisecond: 947, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 17, hour: 7, minute: 20, second: 27, millisecond: 88, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 18, hour: 16, minute: 24, second: 35, millisecond: 142, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    128722319,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 128722319,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1939, month: 10, day: 3, hour: 4, minute: 12, second: 34, millisecond: 178, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 15, hour: 14, minute: 53, second: 51, millisecond: 608, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 2, hour: 17, minute: 8, second: 30, millisecond: 205, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    133629637,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 133629637,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2010, month: 10, day: 7, hour: 15, minute: 15, second: 31, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1934, month: 10, day: 9, hour: 16, minute: 24, second: 42, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1991, month: 10, day: 14, hour: 1, minute: 23, second: 51, millisecond: 39, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 18, hour: 7, minute: 53, second: 35, millisecond: 759, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1917, month: 10, day: 14, hour: 13, minute: 6, second: 50, millisecond: 684, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 7, hour: 10, minute: 18, second: 52, millisecond: 25, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 15, hour: 14, minute: 32, second: 24, millisecond: 70, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2015278073,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    134103655,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 134103655,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1983, month: 10, day: 6, hour: 19, minute: 37, second: 56, millisecond: 208, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 8, hour: 10, minute: 31, second: 50, millisecond: 23, kind: DateTimeKind.Utc),

new DateTime(year: 1967, month: 10, day: 17, hour: 8, minute: 46, second: 5, millisecond: 94, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 16, hour: 22, minute: 41, second: 14, millisecond: 509, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 7, hour: 22, minute: 17, second: 41, millisecond: 708, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 17, hour: 13, minute: 11, second: 22, millisecond: 463, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1523137061,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    143161968,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 143161968,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1934, month: 10, day: 15, hour: 12, minute: 45, second: 26, millisecond: 919, kind: DateTimeKind.Utc),

new DateTime(year: 1932, month: 10, day: 14, hour: 16, minute: 42, second: 12, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 17, hour: 22, minute: 41, second: 34, millisecond: 82, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    222430106,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 222430106,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1942, month: 10, day: 10, hour: 18, minute: 53, second: 26, millisecond: 982, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 19, hour: 21, minute: 32, second: 26, millisecond: 455, kind: DateTimeKind.Utc),

new DateTime(year: 2008, month: 10, day: 15, hour: 13, minute: 49, second: 14, millisecond: 561, kind: DateTimeKind.Utc),

new DateTime(year: 1950, month: 10, day: 9, hour: 22, minute: 55, second: 2, millisecond: 342, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    368908348,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 368908348,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 12, hour: 1, minute: 11, second: 55, millisecond: 215, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 11, hour: 14, minute: 16, second: 44, millisecond: 374, kind: DateTimeKind.Utc),

new DateTime(year: 1929, month: 10, day: 13, hour: 13, minute: 50, second: 23, millisecond: 209, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 1, hour: 7, minute: 2, second: 38, millisecond: 621, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 8, hour: 19, minute: 28, second: 13, millisecond: 577, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 7, hour: 10, minute: 6, second: 42, millisecond: 456, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 16, hour: 9, minute: 22, second: 25, millisecond: 99, kind: DateTimeKind.Utc),

new DateTime(year: 1984, month: 10, day: 11, hour: 18, minute: 30, second: 38, millisecond: 978, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 90766009,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    390439175,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 390439175,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1990, month: 10, day: 13, hour: 6, minute: 8, second: 51, millisecond: 998, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 3, hour: 3, minute: 35, second: 8, millisecond: 778, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 8, hour: 1, minute: 11, second: 51, millisecond: 843, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 19, hour: 2, minute: 2, second: 2, millisecond: 443, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 7, hour: 10, minute: 31, second: 3, millisecond: 438, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 4, hour: 7, minute: 27, second: 14, millisecond: 209, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    408443821,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 408443821,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1928, month: 10, day: 15, hour: 19, minute: 53, second: 30, millisecond: 559, kind: DateTimeKind.Utc),

new DateTime(year: 1989, month: 10, day: 8, hour: 14, minute: 23, second: 24, millisecond: 589, kind: DateTimeKind.Utc),

new DateTime(year: 2019, month: 10, day: 18, hour: 9, minute: 51, second: 38, millisecond: 309, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2009, month: 10, day: 4, hour: 21, minute: 14, second: 7, millisecond: 207, kind: DateTimeKind.Utc),

new DateTime(year: 2018, month: 10, day: 4, hour: 2, minute: 20, second: 5, millisecond: 671, kind: DateTimeKind.Utc),

new DateTime(year: 1926, month: 10, day: 14, hour: 7, minute: 15, second: 8, millisecond: 444, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    480725515,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 480725515,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1948, month: 10, day: 9, hour: 18, minute: 40, second: 28, millisecond: 285, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 8, hour: 18, minute: 5, second: 35, millisecond: 133, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 15, hour: 17, minute: 17, second: 23, millisecond: 536, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 16, hour: 2, minute: 43, second: 2, millisecond: 349, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 10, hour: 17, minute: 22, second: 29, millisecond: 138, kind: DateTimeKind.Utc),

new DateTime(year: 1979, month: 10, day: 3, hour: 6, minute: 28, second: 29, millisecond: 261, kind: DateTimeKind.Utc),

new DateTime(year: 1938, month: 10, day: 4, hour: 16, minute: 10, second: 43, millisecond: 47, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    502697571,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 502697571,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1955, month: 10, day: 9, hour: 2, minute: 48, second: 52, millisecond: 732, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 12, hour: 8, minute: 3, second: 34, millisecond: 872, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 8, hour: 16, minute: 46, second: 50, millisecond: 63, kind: DateTimeKind.Utc),

new DateTime(year: 1921, month: 10, day: 2, hour: 22, minute: 8, second: 31, millisecond: 483, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 15, hour: 15, minute: 28, second: 30, millisecond: 5, kind: DateTimeKind.Utc),

new DateTime(year: 1958, month: 10, day: 3, hour: 8, minute: 4, second: 54, millisecond: 368, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 4, hour: 19, minute: 12, second: 22, millisecond: 721, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1905334939,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    532471242,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 532471242,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1978, month: 10, day: 8, hour: 14, minute: 7, second: 13, millisecond: 457, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 7, hour: 8, minute: 44, second: 51, millisecond: 473, kind: DateTimeKind.Utc),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 31, second: 55, millisecond: 992, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 2, hour: 20, minute: 53, second: 6, millisecond: 334, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 74430180,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    717236245,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 717236245,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1970, month: 10, day: 17, hour: 14, minute: 51, second: 11, millisecond: 715, kind: DateTimeKind.Utc),

new DateTime(year: 1931, month: 10, day: 9, hour: 1, minute: 49, second: 46, millisecond: 366, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 2, hour: 11, minute: 2, second: 12, millisecond: 295, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2147096151,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    758518699,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 758518699,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 2, hour: 8, minute: 40, second: 13, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2007, month: 10, day: 5, hour: 1, minute: 21, second: 1, millisecond: 538, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 6, hour: 10, minute: 3, second: 14, millisecond: 454, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    792961781,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 792961781,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1944, month: 10, day: 15, hour: 3, minute: 47, second: 40, millisecond: 288, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 6, hour: 14, minute: 23, second: 55, millisecond: 33, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 17, hour: 8, minute: 53, second: 18, millisecond: 749, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 12, hour: 9, minute: 29, second: 26, millisecond: 749, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 2, hour: 10, minute: 14, second: 47, millisecond: 201, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 7, hour: 6, minute: 28, second: 13, millisecond: 520, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 15, hour: 1, minute: 14, second: 42, millisecond: 472, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 16, hour: 16, minute: 58, second: 5, millisecond: 235, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1757018207,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    983438495,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 983438495,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 16, hour: 9, minute: 16, second: 52, millisecond: 598, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 7, hour: 21, minute: 35, second: 24, millisecond: 329, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 15, hour: 2, minute: 45, second: 6, millisecond: 211, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 5, hour: 22, minute: 39, second: 18, millisecond: 802, kind: DateTimeKind.Utc),

new DateTime(year: 1936, month: 10, day: 11, hour: 12, minute: 1, second: 23, millisecond: 268, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 2, hour: 1, minute: 29, second: 12, millisecond: 22, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 2140239296,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1026966012,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1026966012,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 4, hour: 18, minute: 45, second: 33, millisecond: 962, kind: DateTimeKind.Utc),

new DateTime(year: 2005, month: 10, day: 17, hour: 2, minute: 22, second: 38, millisecond: 669, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 12, hour: 11, minute: 53, second: 14, millisecond: 168, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1068669733,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1068669733,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1919, month: 10, day: 3, hour: 14, minute: 10, second: 53, millisecond: 76, kind: DateTimeKind.Utc),

new DateTime(year: 2000, month: 10, day: 14, hour: 9, minute: 37, second: 50, millisecond: 676, kind: DateTimeKind.Utc),

new DateTime(year: 1985, month: 10, day: 15, hour: 10, minute: 34, second: 22, millisecond: 479, kind: DateTimeKind.Utc),

new DateTime(year: 1944, month: 10, day: 15, hour: 9, minute: 9, second: 38, millisecond: 201, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1190277834,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1190277834,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1933, month: 10, day: 7, hour: 18, minute: 46, second: 46, millisecond: 994, kind: DateTimeKind.Utc),

new DateTime(year: 1945, month: 10, day: 8, hour: 20, minute: 9, second: 55, millisecond: 873, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 3, minute: 12, second: 43, millisecond: 258, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198128821,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1198128821,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1974, month: 10, day: 13, hour: 15, minute: 25, second: 49, millisecond: 640, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 31, second: 31, millisecond: 273, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 6, hour: 1, minute: 25, second: 42, millisecond: 111, kind: DateTimeKind.Utc),

new DateTime(year: 1924, month: 10, day: 16, hour: 22, minute: 18, second: 29, millisecond: 129, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 3, minute: 7, second: 16, millisecond: 400, kind: DateTimeKind.Utc),

new DateTime(year: 1935, month: 10, day: 18, hour: 8, minute: 55, second: 41, millisecond: 365, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 19, hour: 9, minute: 34, second: 39, millisecond: 550, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 393038928,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1285347857,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1285347857,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1928, month: 10, day: 1, hour: 21, minute: 36, second: 56, millisecond: 985, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 18, hour: 2, minute: 5, second: 49, millisecond: 302, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 7, hour: 10, minute: 42, second: 9, millisecond: 997, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 19, hour: 13, minute: 15, second: 13, millisecond: 637, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1988, month: 10, day: 12, hour: 19, minute: 40, second: 9, millisecond: 500, kind: DateTimeKind.Utc),

new DateTime(year: 1961, month: 10, day: 15, hour: 16, minute: 58, second: 34, millisecond: 742, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 12, hour: 17, minute: 34, second: 15, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 1948, month: 10, day: 19, hour: 20, minute: 18, second: 16, millisecond: 583, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 188249933,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1353665593,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1353665593,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1991, month: 10, day: 8, hour: 22, minute: 5, second: 53, millisecond: 631, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 7, hour: 2, minute: 43, second: 23, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1964, month: 10, day: 10, hour: 6, minute: 28, second: 36, millisecond: 787, kind: DateTimeKind.Utc),

new DateTime(year: 2001, month: 10, day: 6, hour: 1, minute: 43, second: 48, millisecond: 446, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1805809628,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1551152806,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1551152806,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1994, month: 10, day: 12, hour: 17, minute: 29, second: 24, millisecond: 779, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 2, hour: 20, minute: 47, second: 30, millisecond: 360, kind: DateTimeKind.Utc),

new DateTime(year: 2017, month: 10, day: 3, hour: 3, minute: 6, second: 11, millisecond: 33, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 262025274,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1713607458,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1713607458,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2003, month: 10, day: 17, hour: 19, minute: 46, second: 51, millisecond: 251, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 12, hour: 20, minute: 25, second: 28, millisecond: 843, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 15, hour: 11, minute: 56, second: 4, millisecond: 703, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 13, hour: 8, minute: 29, second: 52, millisecond: 772, kind: DateTimeKind.Utc),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1776463757,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1776463757,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1979, month: 10, day: 14, hour: 22, minute: 43, second: 5, millisecond: 754, kind: DateTimeKind.Utc),

new DateTime(year: 2002, month: 10, day: 18, hour: 14, minute: 57, second: 57, millisecond: 894, kind: DateTimeKind.Utc),

new DateTime(year: 1977, month: 10, day: 9, hour: 4, minute: 28, second: 56, millisecond: 984, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2005, month: 10, day: 5, hour: 21, minute: 49, second: 42, millisecond: 859, kind: DateTimeKind.Utc),

new DateTime(year: 2013, month: 10, day: 15, hour: 22, minute: 10, second: 13, millisecond: 712, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 13, hour: 1, minute: 39, second: 10, millisecond: 952, kind: DateTimeKind.Utc),

new DateTime(year: 1927, month: 10, day: 3, hour: 7, minute: 22, second: 41, millisecond: 849, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1990053873,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1878827244,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1878827244,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1990, month: 10, day: 6, hour: 12, minute: 49, second: 21, millisecond: 124, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 10, hour: 18, minute: 30, second: 3, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 1941, month: 10, day: 19, hour: 17, minute: 34, second: 39, millisecond: 531, kind: DateTimeKind.Utc),

new DateTime(year: 1942, month: 10, day: 9, hour: 3, minute: 4, second: 45, millisecond: 201, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 2, minute: 46, second: 24, millisecond: 17, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 17, hour: 22, minute: 42, second: 26, millisecond: 937, kind: DateTimeKind.Utc),

new DateTime(year: 1971, month: 10, day: 10, hour: 6, minute: 34, second: 13, millisecond: 230, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1913431385,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

}
                        }

                    }
                );

                expected.Add(
                    1880962063,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 1880962063,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1980, month: 10, day: 13, hour: 3, minute: 28, second: 12, millisecond: 367, kind: DateTimeKind.Utc),

new DateTime(year: 1988, month: 10, day: 5, hour: 3, minute: 11, second: 7, millisecond: 282, kind: DateTimeKind.Utc),

new DateTime(year: 1951, month: 10, day: 5, hour: 1, minute: 42, second: 24, millisecond: 385, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 14, hour: 5, minute: 58, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1976, month: 10, day: 4, hour: 11, minute: 47, second: 10, millisecond: 361, kind: DateTimeKind.Utc),

new DateTime(year: 1946, month: 10, day: 1, hour: 3, minute: 23, second: 5, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2016, month: 10, day: 13, hour: 3, minute: 12, second: 7, millisecond: 87, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2010990844,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 2010990844,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1975, month: 10, day: 2, hour: 1, minute: 12, second: 5, millisecond: 345, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 14, hour: 21, minute: 34, second: 36, millisecond: 628, kind: DateTimeKind.Utc),

new DateTime(year: 2015, month: 10, day: 7, hour: 9, minute: 17, second: 24, millisecond: 896, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1993, month: 10, day: 19, hour: 4, minute: 49, second: 20, millisecond: 9, kind: DateTimeKind.Utc),

new DateTime(year: 1956, month: 10, day: 5, hour: 11, minute: 52, second: 27, millisecond: 745, kind: DateTimeKind.Utc),

new DateTime(year: 2006, month: 10, day: 16, hour: 15, minute: 20, second: 20, millisecond: 413, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 2, hour: 20, minute: 15, second: 27, millisecond: 940, kind: DateTimeKind.Utc),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2067662540,
                    new DateTimetimestamp_with_time_zoneArray1M
                    {
                        Id = 2067662540,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 15, hour: 3, minute: 21, second: 12, millisecond: 643, kind: DateTimeKind.Utc),

new DateTime(year: 1962, month: 10, day: 4, hour: 3, minute: 48, second: 50, millisecond: 463, kind: DateTimeKind.Utc),

new DateTime(year: 1952, month: 10, day: 5, hour: 11, minute: 55, second: 17, millisecond: 688, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2005, month: 10, day: 19, hour: 3, minute: 3, second: 26, millisecond: 7, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 17, hour: 15, minute: 23, second: 7, millisecond: 905, kind: DateTimeKind.Utc),

new DateTime(year: 1922, month: 10, day: 4, hour: 5, minute: 30, second: 1, millisecond: 660, kind: DateTimeKind.Utc),

},

                        ModelInner = new DateTimetimestamp_with_time_zoneArray1MI
                        {
                            Id = 1192876633,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zoneArray1MI),
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray1MI>(15);

                expected.Add(
                    74430180,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 74430180,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    90766009,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 90766009,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    188249933,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 188249933,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    262025274,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 262025274,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    393038928,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 393038928,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1192876633,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1192876633,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1523137061,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1523137061,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1757018207,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1757018207,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1805809628,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1805809628,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1905334939,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1905334939,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1913431385,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1913431385,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1990053873,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1990053873,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2015278073,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2015278073,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2140239296,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2140239296,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    2147096151,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2147096151,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zoneArray1MI>(15);

                expected.Add(
                    74430180,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 74430180,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1932, month: 10, day: 16, hour: 5, minute: 3, second: 57, millisecond: 446, kind: DateTimeKind.Utc),

new DateTime(year: 1960, month: 10, day: 6, hour: 4, minute: 33, second: 26, millisecond: 518, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 11, hour: 12, minute: 55, second: 42, millisecond: 493, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    90766009,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 90766009,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1953, month: 10, day: 5, hour: 3, minute: 50, second: 14, millisecond: 355, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 3, hour: 8, minute: 36, second: 20, millisecond: 909, kind: DateTimeKind.Utc),

new DateTime(year: 1955, month: 10, day: 2, hour: 8, minute: 5, second: 32, millisecond: 185, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    188249933,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 188249933,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1927, month: 10, day: 9, hour: 1, minute: 50, second: 22, millisecond: 772, kind: DateTimeKind.Utc),

new DateTime(year: 1974, month: 10, day: 8, hour: 6, minute: 12, second: 56, millisecond: 265, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 10, hour: 20, minute: 51, second: 12, millisecond: 600, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    262025274,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 262025274,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2015, month: 10, day: 3, hour: 3, minute: 40, second: 41, millisecond: 793, kind: DateTimeKind.Utc),

new DateTime(year: 1918, month: 10, day: 19, hour: 19, minute: 7, second: 28, millisecond: 850, kind: DateTimeKind.Utc),

new DateTime(year: 1970, month: 10, day: 18, hour: 14, minute: 29, second: 23, millisecond: 65, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    393038928,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 393038928,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 11, hour: 2, minute: 22, second: 13, millisecond: 674, kind: DateTimeKind.Utc),

new DateTime(year: 1933, month: 10, day: 11, hour: 1, minute: 25, second: 33, millisecond: 930, kind: DateTimeKind.Utc),

new DateTime(year: 1937, month: 10, day: 18, hour: 11, minute: 38, second: 38, millisecond: 975, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 9, hour: 1, minute: 42, second: 28, millisecond: 43, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 7, hour: 12, minute: 49, second: 10, millisecond: 886, kind: DateTimeKind.Utc),

new DateTime(year: 1968, month: 10, day: 3, hour: 21, minute: 44, second: 7, millisecond: 611, kind: DateTimeKind.Utc),

new DateTime(year: 1996, month: 10, day: 8, hour: 4, minute: 53, second: 4, millisecond: 223, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1192876633,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1192876633,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1966, month: 10, day: 2, hour: 6, minute: 15, second: 8, millisecond: 51, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 12, hour: 11, minute: 41, second: 14, millisecond: 234, kind: DateTimeKind.Utc),

new DateTime(year: 1997, month: 10, day: 10, hour: 4, minute: 33, second: 21, millisecond: 506, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 10, hour: 4, minute: 13, second: 15, millisecond: 705, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1959, month: 10, day: 10, hour: 3, minute: 15, second: 32, millisecond: 346, kind: DateTimeKind.Utc),

new DateTime(year: 1995, month: 10, day: 8, hour: 2, minute: 7, second: 32, millisecond: 963, kind: DateTimeKind.Utc),

new DateTime(year: 2014, month: 10, day: 16, hour: 3, minute: 1, second: 10, millisecond: 824, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 1, hour: 20, minute: 18, second: 21, millisecond: 881, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1523137061,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1523137061,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 15, hour: 15, minute: 41, second: 17, millisecond: 417, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 1, hour: 20, minute: 4, second: 19, millisecond: 838, kind: DateTimeKind.Utc),

new DateTime(year: 2003, month: 10, day: 10, hour: 6, minute: 4, second: 2, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1992, month: 10, day: 11, hour: 15, minute: 23, second: 4, millisecond: 103, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1954, month: 10, day: 15, hour: 11, minute: 32, second: 21, millisecond: 496, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 13, hour: 15, minute: 51, second: 34, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1980, month: 10, day: 14, hour: 3, minute: 53, second: 9, millisecond: 863, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1757018207,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1757018207,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1938, month: 10, day: 12, hour: 19, minute: 53, second: 14, millisecond: 334, kind: DateTimeKind.Utc),

new DateTime(year: 1957, month: 10, day: 2, hour: 20, minute: 31, second: 45, millisecond: 842, kind: DateTimeKind.Utc),

new DateTime(year: 2011, month: 10, day: 14, hour: 13, minute: 2, second: 33, millisecond: 415, kind: DateTimeKind.Utc),

new DateTime(year: 1954, month: 10, day: 5, hour: 16, minute: 19, second: 22, millisecond: 202, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1805809628,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1805809628,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1984, month: 10, day: 17, hour: 20, minute: 3, second: 43, millisecond: 634, kind: DateTimeKind.Utc),

new DateTime(year: 1930, month: 10, day: 2, hour: 2, minute: 4, second: 29, millisecond: 953, kind: DateTimeKind.Utc),

new DateTime(year: 1947, month: 10, day: 1, hour: 6, minute: 12, second: 29, millisecond: 106, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1905334939,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1905334939,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2011, month: 10, day: 16, hour: 7, minute: 46, second: 32, millisecond: 973, kind: DateTimeKind.Utc),

new DateTime(year: 1986, month: 10, day: 14, hour: 3, minute: 53, second: 44, millisecond: 880, kind: DateTimeKind.Utc),

new DateTime(year: 1965, month: 10, day: 13, hour: 13, minute: 41, second: 58, millisecond: 189, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2003, month: 10, day: 1, hour: 21, minute: 11, second: 42, millisecond: 672, kind: DateTimeKind.Utc),

new DateTime(year: 1953, month: 10, day: 2, hour: 17, minute: 27, second: 38, millisecond: 342, kind: DateTimeKind.Utc),

new DateTime(year: 1963, month: 10, day: 15, hour: 13, minute: 21, second: 56, millisecond: 393, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1913431385,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1913431385,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2014, month: 10, day: 14, hour: 20, minute: 17, second: 8, millisecond: 35, kind: DateTimeKind.Utc),

new DateTime(year: 1959, month: 10, day: 11, hour: 8, minute: 8, second: 58, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 21, second: 21, millisecond: 704, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1989, month: 10, day: 14, hour: 17, minute: 21, second: 34, millisecond: 352, kind: DateTimeKind.Utc),

new DateTime(year: 1939, month: 10, day: 9, hour: 22, minute: 26, second: 47, millisecond: 595, kind: DateTimeKind.Utc),

new DateTime(year: 1987, month: 10, day: 10, hour: 6, minute: 57, second: 39, millisecond: 14, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    1990053873,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 1990053873,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2013, month: 10, day: 9, hour: 14, minute: 44, second: 53, millisecond: 238, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 16, hour: 13, minute: 24, second: 31, millisecond: 804, kind: DateTimeKind.Utc),

new DateTime(year: 2004, month: 10, day: 13, hour: 13, minute: 37, second: 34, millisecond: 724, kind: DateTimeKind.Utc),

new DateTime(year: 1993, month: 10, day: 1, hour: 10, minute: 31, second: 15, millisecond: 835, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2015278073,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2015278073,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1988, month: 10, day: 7, hour: 8, minute: 35, second: 6, millisecond: 664, kind: DateTimeKind.Utc),

new DateTime(year: 1925, month: 10, day: 8, hour: 18, minute: 2, second: 57, millisecond: 460, kind: DateTimeKind.Utc),

new DateTime(year: 1998, month: 10, day: 5, hour: 3, minute: 12, second: 27, millisecond: 607, kind: DateTimeKind.Utc),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2140239296,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2140239296,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 14, hour: 1, minute: 11, second: 47, millisecond: 933, kind: DateTimeKind.Utc),

new DateTime(year: 2009, month: 10, day: 8, hour: 8, minute: 23, second: 20, millisecond: 547, kind: DateTimeKind.Utc),

new DateTime(year: 1982, month: 10, day: 18, hour: 14, minute: 42, second: 49, millisecond: 550, kind: DateTimeKind.Utc),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2014, month: 10, day: 18, hour: 13, minute: 55, second: 31, millisecond: 683, kind: DateTimeKind.Utc),

new DateTime(year: 1981, month: 10, day: 4, hour: 7, minute: 23, second: 11, millisecond: 555, kind: DateTimeKind.Utc),

new DateTime(year: 1978, month: 10, day: 12, hour: 8, minute: 37, second: 52, millisecond: 827, kind: DateTimeKind.Utc),

new DateTime(year: 1940, month: 10, day: 1, hour: 17, minute: 16, second: 53, millisecond: 712, kind: DateTimeKind.Utc),

}
                    }
                );

                expected.Add(
                    2147096151,
                    new DateTimetimestamp_with_time_zoneArray1MI
                    {
                        Id = 2147096151,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 4, hour: 2, minute: 29, second: 38, millisecond: 255, kind: DateTimeKind.Utc),

new DateTime(year: 1975, month: 10, day: 13, hour: 12, minute: 24, second: 27, millisecond: 336, kind: DateTimeKind.Utc),

new DateTime(year: 1917, month: 10, day: 17, hour: 8, minute: 50, second: 9, millisecond: 733, kind: DateTimeKind.Utc),

new DateTime(year: 1999, month: 10, day: 6, hour: 21, minute: 46, second: 4, millisecond: 506, kind: DateTimeKind.Utc),

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


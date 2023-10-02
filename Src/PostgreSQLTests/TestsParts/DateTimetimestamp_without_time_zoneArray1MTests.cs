

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
    internal partial interface IDateTimeArraytimestamp_without_time_zoneArray
    {
    }
    
    internal partial class DateTimeArraytimestamp_without_time_zoneArray : IDateTimeArraytimestamp_without_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1mi(
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1mi(
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
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInner(connection, 10726883, 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInner(connection, 247996182, 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

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

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1348122569, 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1743287547, 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

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

                id =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, 450433491, 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

});
                Assert.That(id, Is.EqualTo(450433491));

                id =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturning(connection, 1877988499, 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(1877988499));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1274823456, 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

});
                Assert.That(id, Is.EqualTo(1274823456));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 967936046, 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(967936046));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 892351305, 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

});
                Assert.That(id, Is.EqualTo(892351305));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1330617629, 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(1330617629));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 485110016, 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

});
                Assert.That(id, Is.EqualTo(485110016));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1494950797, 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(1494950797));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1451416793, 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

});
                Assert.That(id, Is.EqualTo(1451416793));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 525726109, 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(525726109));

                id = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1778035144, 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

}, null);
                Assert.That(id, Is.EqualTo(1778035144));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray1mi_id
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray1mi_id", 
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

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModel(connection, 684677716, 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModel(connection, 1407937183, 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

}, 10726883);
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

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelAsync(connection, 318883933, 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelAsync(connection, 1361464242, 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

}, null, 247996182);
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

                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, 1232662251, 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

}));

                nullable =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturning(connection, 968318521, 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

}, null, 1348122569);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime[] nullable = null;

                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 1030710258, 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

}));

                nullable = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 98307791, 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

}, 1743287547);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonearray1mi_id
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
    datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483627)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonearray1mi_id", 
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
                List<DateTimetimestamp_without_time_zoneArray1M> models = null;
                DateTimetimestamp_without_time_zoneArray1M model = null;

                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, 1624942780, 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, 291886589, 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

}, 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

}, 450433491).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, 896276553, 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturning(connection, 820236148, 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

}, null, 1877988499).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

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
                List<DateTimetimestamp_without_time_zoneArray1M> models = null;
                DateTimetimestamp_without_time_zoneArray1M model = null;

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 674853443, 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1177273769, 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

}, 1274823456).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2142778822, 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1621415047, 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

}, null, 967936046).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2026323450, 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1597296560, 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

}, null, 892351305).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 753851158, 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1500142940, 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

}, null, 1330617629).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 406238909, 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1907542105, 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

}, 485110016).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 928790969, 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1248122919, 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

}, null, 1494950797).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 430711759, 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 192167717, 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

}, 
new System.DateTime[4]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

}, 1451416793).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 553031022, 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 543871825, 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

}, null, 525726109).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 484200126, 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1386214273, 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

}, null, 1778035144).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
FROM public.datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                 using var cmd =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 896276553);
                var models =  ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                await using var cmd = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeArraytimestamp_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 318883933);
                var models = await ((IDateTimeArraytimestamp_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
            asPartInterface: typeof(IDateTimeArraytimestamp_without_time_zoneArray)
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
                 foreach(var batchResult in ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 684677716, 1248122919))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                await foreach(var batchResult in ((IDateTimeArraytimestamp_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 968318521, 318883933))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
FROM public.binary_datetimetimestamp_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MI),
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

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1MI>(7);

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 10726883,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 247996182,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 450433491,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 485110016,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 525726109,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 892351305,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 967936046,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10726883));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(247996182));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(450433491));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(485110016));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(525726109));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(892351305));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(967936046));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1274823456,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1330617629,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1348122569,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1451416793,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

}
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1494950797,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1743287547,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1778035144,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1MI
                {
                    Id = 1877988499,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10726883));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(247996182));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(450433491));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(485110016));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(525726109));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(892351305));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(967936046));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1274823456));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1330617629));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1348122569));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1451416793));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1494950797));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1743287547));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1778035144));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1877988499));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
COPY public.binary_datetimetimestamp_without_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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
FROM public.binary_datetimetimestamp_without_time_zonearray1m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonearray1mi mi ON mi.id = m.datetimetimestamp_without_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
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

                var importCollection = new List<DateTimetimestamp_without_time_zoneArray1M>(15);

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 98307791,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1743287547
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 192167717,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1451416793
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 291886589,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 450433491
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 318883933,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 406238909,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 430711759,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 484200126,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 543871825,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 525726109
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 553031022,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 674853443,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 684677716,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 753851158,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 820236148,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1877988499
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 896276553,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 928790969,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 968318521,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1348122569
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1030710258,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1177273769,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1274823456
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1232662251,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1248122919,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1494950797
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1361464242,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 247996182
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1386214273,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1778035144
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1407937183,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 10726883
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1500142940,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 1330617629
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1597296560,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 892351305
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1621415047,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

},
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 967936046
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1624942780,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 1907542105,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

},

                    ModelInner = new DateTimetimestamp_without_time_zoneArray1MI 
                    {
                        Id = 485110016
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 2026323450,
                    Value = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zoneArray1M
                {
                    Id = 2142778822,
                    Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

},
                    NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98307791));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743287547));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(192167717));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1451416793));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(291886589));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(450433491));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(318883933));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(406238909));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(430711759));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(484200126));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(543871825));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(525726109));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(553031022));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(674853443));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(684677716));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(753851158));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(820236148));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1877988499));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(896276553));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(928790969));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(968318521));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1348122569));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1030710258));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1177273769));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1274823456));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1232662251));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1248122919));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1494950797));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1361464242));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247996182));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1386214273));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1778035144));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1407937183));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(10726883));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1500142940));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1330617629));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1597296560));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(892351305));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(1621415047));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(967936046));

                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1624942780));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(1907542105));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(485110016));

                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

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
                Assert.That(model.Id, Is.EqualTo(2026323450));
                {
                    var expectEnumerValue = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

};
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
                Assert.That(model.Id, Is.EqualTo(2142778822));
                {
                    var expectEnumerValue = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

};
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
COPY public.binary_datetimetimestamp_without_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zoneArray1M>(30);

                expected.Add(
                    98307791,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 98307791,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1743287547,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    192167717,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 192167717,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1451416793,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    291886589,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 291886589,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 450433491,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    318883933,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 318883933,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    406238909,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 406238909,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    430711759,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 430711759,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    484200126,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 484200126,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    543871825,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 543871825,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 525726109,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    553031022,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 553031022,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    674853443,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 674853443,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    684677716,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 684677716,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    753851158,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 753851158,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    820236148,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 820236148,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1877988499,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    896276553,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 896276553,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    928790969,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 928790969,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    968318521,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 968318521,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1348122569,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1030710258,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1030710258,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1177273769,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1177273769,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1274823456,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1232662251,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1232662251,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1248122919,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1248122919,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1494950797,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1361464242,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1361464242,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 247996182,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1386214273,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1386214273,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1778035144,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1407937183,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1407937183,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 10726883,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1500142940,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1500142940,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1330617629,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1597296560,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1597296560,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 892351305,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1621415047,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1621415047,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 967936046,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1624942780,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1624942780,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1907542105,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1907542105,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 485110016,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    2026323450,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 2026323450,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2142778822,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 2142778822,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zoneArray1M>(30);

                expected.Add(
                    98307791,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 98307791,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1936, month: 10, day: 18, hour: 21, minute: 45, second: 25, millisecond: 759, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 4, hour: 6, minute: 52, second: 53, millisecond: 279, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 11, hour: 11, minute: 10, second: 3, millisecond: 867, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1996, month: 10, day: 14, hour: 6, minute: 14, second: 24, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1921, month: 10, day: 2, hour: 4, minute: 16, second: 38, millisecond: 60, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 11, hour: 17, minute: 13, second: 19, millisecond: 48, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1743287547,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    192167717,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 192167717,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1952, month: 10, day: 3, hour: 1, minute: 9, second: 47, millisecond: 469, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 1, hour: 20, minute: 45, second: 47, millisecond: 958, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 18, hour: 8, minute: 17, second: 22, millisecond: 641, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2004, month: 10, day: 1, hour: 1, minute: 22, second: 37, millisecond: 579, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 9, hour: 4, minute: 37, second: 35, millisecond: 812, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 19, hour: 10, minute: 46, second: 45, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 5, hour: 1, minute: 21, second: 13, millisecond: 520, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1451416793,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    291886589,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 291886589,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 52, second: 56, millisecond: 10, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 3, hour: 16, minute: 40, second: 13, millisecond: 457, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 18, hour: 9, minute: 33, second: 26, millisecond: 728, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 16, hour: 13, minute: 16, second: 47, millisecond: 255, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 16, hour: 13, minute: 40, second: 52, millisecond: 950, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 17, hour: 19, minute: 17, second: 37, millisecond: 49, kind: DateTimeKind.Local),

new DateTime(year: 1931, month: 10, day: 2, hour: 15, minute: 2, second: 43, millisecond: 856, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 450433491,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    318883933,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 318883933,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2001, month: 10, day: 6, hour: 7, minute: 52, second: 24, millisecond: 238, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 7, hour: 7, minute: 16, second: 9, millisecond: 132, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 1, hour: 5, minute: 16, second: 25, millisecond: 748, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1949, month: 10, day: 5, hour: 12, minute: 49, second: 51, millisecond: 931, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 15, hour: 13, minute: 35, second: 17, millisecond: 487, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 7, hour: 20, minute: 51, second: 27, millisecond: 938, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    406238909,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 406238909,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 9, hour: 5, minute: 44, second: 48, millisecond: 426, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 8, hour: 21, minute: 7, second: 29, millisecond: 621, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 15, minute: 28, second: 42, millisecond: 325, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    430711759,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 430711759,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2016, month: 10, day: 7, hour: 1, minute: 50, second: 34, millisecond: 547, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 12, hour: 21, minute: 5, second: 36, millisecond: 599, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 19, hour: 2, minute: 14, second: 46, millisecond: 192, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    484200126,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 484200126,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 2, hour: 4, minute: 34, second: 41, millisecond: 178, kind: DateTimeKind.Local),

new DateTime(year: 1933, month: 10, day: 11, hour: 11, minute: 51, second: 41, millisecond: 518, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 4, hour: 13, minute: 10, second: 45, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 13, hour: 17, minute: 14, second: 55, millisecond: 145, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    543871825,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 543871825,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2018, month: 10, day: 14, hour: 7, minute: 6, second: 48, millisecond: 593, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 4, hour: 22, minute: 53, second: 56, millisecond: 410, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 12, hour: 1, minute: 37, second: 10, millisecond: 813, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 525726109,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    553031022,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 553031022,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 7, hour: 15, minute: 25, second: 7, millisecond: 149, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 3, hour: 21, minute: 1, second: 5, millisecond: 64, kind: DateTimeKind.Local),

new DateTime(year: 1966, month: 10, day: 1, hour: 6, minute: 56, second: 58, millisecond: 790, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 15, minute: 18, second: 36, millisecond: 52, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    674853443,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 674853443,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 6, hour: 2, minute: 1, second: 29, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1967, month: 10, day: 17, hour: 19, minute: 27, second: 14, millisecond: 319, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 5, minute: 33, second: 28, millisecond: 874, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 10, minute: 40, second: 4, millisecond: 206, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    684677716,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 684677716,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1935, month: 10, day: 2, hour: 6, minute: 26, second: 4, millisecond: 323, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 11, hour: 9, minute: 50, second: 36, millisecond: 834, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 17, hour: 12, minute: 23, second: 57, millisecond: 779, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 18, hour: 8, minute: 14, second: 50, millisecond: 327, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 57, second: 29, millisecond: 63, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 7, hour: 22, minute: 36, second: 39, millisecond: 613, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 2, hour: 10, minute: 18, second: 2, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 19, hour: 6, minute: 2, second: 16, millisecond: 566, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    753851158,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 753851158,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1944, month: 10, day: 10, hour: 10, minute: 5, second: 30, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2018, month: 10, day: 18, hour: 2, minute: 40, second: 49, millisecond: 872, kind: DateTimeKind.Local),

new DateTime(year: 1991, month: 10, day: 2, hour: 20, minute: 26, second: 25, millisecond: 301, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    820236148,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 820236148,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1934, month: 10, day: 19, hour: 12, minute: 35, second: 5, millisecond: 876, kind: DateTimeKind.Local),

new DateTime(year: 2004, month: 10, day: 4, hour: 20, minute: 18, second: 32, millisecond: 901, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 2, hour: 18, minute: 15, second: 2, millisecond: 53, kind: DateTimeKind.Local),

new DateTime(year: 1975, month: 10, day: 12, hour: 10, minute: 2, second: 1, millisecond: 854, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1877988499,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    896276553,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 896276553,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1986, month: 10, day: 15, hour: 7, minute: 54, second: 14, millisecond: 217, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 15, hour: 5, minute: 32, second: 14, millisecond: 620, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 11, minute: 25, second: 19, millisecond: 870, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    928790969,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 928790969,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1924, month: 10, day: 16, hour: 19, minute: 55, second: 34, millisecond: 517, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 6, hour: 4, minute: 47, second: 53, millisecond: 954, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 12, hour: 18, minute: 21, second: 43, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 7, hour: 8, minute: 42, second: 44, millisecond: 316, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 9, hour: 20, minute: 57, second: 30, millisecond: 324, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 15, hour: 7, minute: 23, second: 22, millisecond: 857, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 10, hour: 16, minute: 36, second: 42, millisecond: 751, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 9, hour: 2, minute: 12, second: 40, millisecond: 114, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    968318521,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 968318521,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1941, month: 10, day: 7, hour: 9, minute: 7, second: 31, millisecond: 585, kind: DateTimeKind.Local),

new DateTime(year: 1999, month: 10, day: 19, hour: 18, minute: 3, second: 11, millisecond: 121, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 10, hour: 22, minute: 20, second: 36, millisecond: 51, kind: DateTimeKind.Local),

new DateTime(year: 2009, month: 10, day: 7, hour: 10, minute: 39, second: 16, millisecond: 443, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1348122569,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1030710258,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1030710258,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1982, month: 10, day: 3, hour: 15, minute: 16, second: 4, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 5, hour: 4, minute: 19, second: 6, millisecond: 20, kind: DateTimeKind.Local),

new DateTime(year: 2001, month: 10, day: 5, hour: 9, minute: 23, second: 28, millisecond: 457, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1935, month: 10, day: 5, hour: 13, minute: 51, second: 24, millisecond: 771, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 1, hour: 5, minute: 54, second: 5, millisecond: 840, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 16, hour: 8, minute: 51, second: 2, millisecond: 658, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1177273769,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1177273769,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1965, month: 10, day: 11, hour: 22, minute: 27, second: 40, millisecond: 156, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 2, hour: 13, minute: 3, second: 25, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 2014, month: 10, day: 8, hour: 13, minute: 4, second: 53, millisecond: 717, kind: DateTimeKind.Local),

new DateTime(year: 2007, month: 10, day: 15, hour: 22, minute: 58, second: 1, millisecond: 915, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1945, month: 10, day: 3, hour: 9, minute: 3, second: 2, millisecond: 76, kind: DateTimeKind.Local),

new DateTime(year: 1986, month: 10, day: 5, hour: 10, minute: 30, second: 1, millisecond: 971, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 3, hour: 7, minute: 7, second: 8, millisecond: 879, kind: DateTimeKind.Local),

new DateTime(year: 2008, month: 10, day: 7, hour: 18, minute: 45, second: 19, millisecond: 46, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1274823456,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1232662251,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1232662251,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1998, month: 10, day: 2, hour: 19, minute: 58, second: 53, millisecond: 545, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 9, hour: 1, minute: 34, second: 7, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 5, hour: 21, minute: 38, second: 44, millisecond: 44, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 2019, month: 10, day: 7, hour: 2, minute: 16, second: 22, millisecond: 463, kind: DateTimeKind.Local),

new DateTime(year: 1993, month: 10, day: 19, hour: 16, minute: 9, second: 7, millisecond: 158, kind: DateTimeKind.Local),

new DateTime(year: 2016, month: 10, day: 7, hour: 4, minute: 16, second: 1, millisecond: 286, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1248122919,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1248122919,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1967, month: 10, day: 11, hour: 9, minute: 16, second: 3, millisecond: 700, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 1, hour: 19, minute: 21, second: 41, millisecond: 524, kind: DateTimeKind.Local),

new DateTime(year: 1949, month: 10, day: 4, hour: 1, minute: 7, second: 43, millisecond: 85, kind: DateTimeKind.Local),

new DateTime(year: 2013, month: 10, day: 6, hour: 3, minute: 4, second: 48, millisecond: 77, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1494950797,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1361464242,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1361464242,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1973, month: 10, day: 13, hour: 8, minute: 18, second: 25, millisecond: 887, kind: DateTimeKind.Local),

new DateTime(year: 1989, month: 10, day: 5, hour: 13, minute: 5, second: 10, millisecond: 195, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 17, hour: 1, minute: 2, second: 23, millisecond: 617, kind: DateTimeKind.Local),

new DateTime(year: 1924, month: 10, day: 13, hour: 1, minute: 15, second: 51, millisecond: 20, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 247996182,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1386214273,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1386214273,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1954, month: 10, day: 6, hour: 5, minute: 14, second: 2, millisecond: 628, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 19, hour: 10, minute: 29, second: 53, millisecond: 809, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 18, hour: 19, minute: 36, second: 48, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1930, month: 10, day: 13, hour: 9, minute: 45, second: 10, millisecond: 626, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1778035144,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1407937183,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1407937183,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1933, month: 10, day: 1, hour: 19, minute: 46, second: 12, millisecond: 437, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 2, minute: 25, second: 36, millisecond: 185, kind: DateTimeKind.Local),

new DateTime(year: 1987, month: 10, day: 19, hour: 14, minute: 6, second: 1, millisecond: 965, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 24, second: 20, millisecond: 54, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1937, month: 10, day: 2, hour: 17, minute: 16, second: 11, millisecond: 467, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 13, hour: 22, minute: 20, second: 27, millisecond: 817, kind: DateTimeKind.Local),

new DateTime(year: 2019, month: 10, day: 8, hour: 8, minute: 33, second: 6, millisecond: 71, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 10726883,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1500142940,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1500142940,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 32, second: 8, millisecond: 833, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 5, hour: 12, minute: 1, second: 39, millisecond: 387, kind: DateTimeKind.Local),

new DateTime(year: 1937, month: 10, day: 10, hour: 19, minute: 12, second: 9, millisecond: 673, kind: DateTimeKind.Local),

new DateTime(year: 2011, month: 10, day: 6, hour: 3, minute: 44, second: 58, millisecond: 757, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 1330617629,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1597296560,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1597296560,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1977, month: 10, day: 10, hour: 20, minute: 30, second: 40, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 1, hour: 8, minute: 7, second: 38, millisecond: 919, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 14, hour: 14, minute: 51, second: 8, millisecond: 996, kind: DateTimeKind.Local),

new DateTime(year: 1984, month: 10, day: 19, hour: 7, minute: 55, second: 54, millisecond: 127, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 892351305,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    1621415047,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1621415047,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1931, month: 10, day: 1, hour: 8, minute: 54, second: 31, millisecond: 367, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 3, hour: 22, minute: 36, second: 6, millisecond: 226, kind: DateTimeKind.Local),

new DateTime(year: 1941, month: 10, day: 19, hour: 16, minute: 46, second: 58, millisecond: 408, kind: DateTimeKind.Local),

},
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 967936046,
                            Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1624942780,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1624942780,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 2006, month: 10, day: 15, hour: 4, minute: 29, second: 13, millisecond: 600, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 14, hour: 21, minute: 41, second: 12, millisecond: 361, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 15, hour: 15, minute: 41, second: 15, millisecond: 896, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1995, month: 10, day: 9, hour: 19, minute: 58, second: 29, millisecond: 259, kind: DateTimeKind.Local),

new DateTime(year: 1955, month: 10, day: 12, hour: 21, minute: 26, second: 37, millisecond: 711, kind: DateTimeKind.Local),

new DateTime(year: 1994, month: 10, day: 3, hour: 17, minute: 56, second: 45, millisecond: 510, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1907542105,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 1907542105,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 2012, month: 10, day: 4, hour: 19, minute: 50, second: 11, millisecond: 34, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 1, hour: 15, minute: 35, second: 6, millisecond: 153, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 2, hour: 11, minute: 18, second: 43, millisecond: 960, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 14, hour: 8, minute: 14, second: 44, millisecond: 338, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1947, month: 10, day: 4, hour: 12, minute: 17, second: 7, millisecond: 187, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 16, hour: 10, minute: 43, second: 15, millisecond: 663, kind: DateTimeKind.Local),

new DateTime(year: 1919, month: 10, day: 18, hour: 14, minute: 57, second: 5, millisecond: 820, kind: DateTimeKind.Local),

new DateTime(year: 1922, month: 10, day: 8, hour: 3, minute: 2, second: 49, millisecond: 597, kind: DateTimeKind.Local),

},

                        ModelInner = new DateTimetimestamp_without_time_zoneArray1MI
                        {
                            Id = 485110016,
                            Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

},
                            NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

}
                        }

                    }
                );

                expected.Add(
                    2026323450,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 2026323450,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1918, month: 10, day: 17, hour: 7, minute: 6, second: 29, millisecond: 196, kind: DateTimeKind.Local),

new DateTime(year: 2000, month: 10, day: 11, hour: 3, minute: 25, second: 57, millisecond: 743, kind: DateTimeKind.Local),

new DateTime(year: 1985, month: 10, day: 3, hour: 5, minute: 21, second: 4, millisecond: 647, kind: DateTimeKind.Local),

new DateTime(year: 1940, month: 10, day: 9, hour: 7, minute: 19, second: 53, millisecond: 532, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 7, hour: 14, minute: 37, second: 34, millisecond: 523, kind: DateTimeKind.Local),

new DateTime(year: 1934, month: 10, day: 3, hour: 16, minute: 26, second: 54, millisecond: 175, kind: DateTimeKind.Local),

new DateTime(year: 1971, month: 10, day: 1, hour: 6, minute: 1, second: 49, millisecond: 749, kind: DateTimeKind.Local),

new DateTime(year: 1932, month: 10, day: 19, hour: 17, minute: 37, second: 34, millisecond: 319, kind: DateTimeKind.Local),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2142778822,
                    new DateTimetimestamp_without_time_zoneArray1M
                    {
                        Id = 2142778822,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1943, month: 10, day: 13, hour: 4, minute: 13, second: 36, millisecond: 639, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 9, hour: 4, minute: 39, second: 27, millisecond: 672, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 3, hour: 19, minute: 10, second: 12, millisecond: 973, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1932, month: 10, day: 5, hour: 14, minute: 40, second: 16, millisecond: 627, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 11, hour: 1, minute: 40, second: 20, millisecond: 62, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 14, hour: 6, minute: 43, second: 7, millisecond: 479, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 2, hour: 11, minute: 31, second: 58, millisecond: 878, kind: DateTimeKind.Local),

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
COPY public.binary_datetimetimestamp_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627),
                (NpgsqlTypes.NpgsqlDbType)(-2147483627)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zoneArray1MI>(15);

                expected.Add(
                    10726883,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 10726883,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    247996182,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 247996182,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    450433491,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 450433491,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    485110016,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 485110016,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    525726109,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 525726109,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    892351305,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 892351305,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    967936046,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 967936046,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1274823456,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1274823456,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1330617629,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1330617629,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1348122569,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1348122569,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1451416793,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1451416793,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1494950797,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1494950797,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1743287547,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1743287547,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1778035144,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1778035144,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1877988499,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1877988499,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zoneArray1MI>(15);

                expected.Add(
                    10726883,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 10726883,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1936, month: 10, day: 4, hour: 21, minute: 32, second: 51, millisecond: 35, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 18, hour: 11, minute: 9, second: 19, millisecond: 808, kind: DateTimeKind.Local),

new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 52, second: 57, millisecond: 836, kind: DateTimeKind.Local),

new DateTime(year: 1962, month: 10, day: 13, hour: 7, minute: 20, second: 1, millisecond: 730, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1969, month: 10, day: 9, hour: 14, minute: 21, second: 45, millisecond: 137, kind: DateTimeKind.Local),

new DateTime(year: 1969, month: 10, day: 7, hour: 5, minute: 9, second: 9, millisecond: 261, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 1, hour: 1, minute: 44, second: 3, millisecond: 594, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    247996182,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 247996182,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1963, month: 10, day: 5, hour: 16, minute: 48, second: 39, millisecond: 135, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 6, hour: 18, minute: 49, second: 41, millisecond: 967, kind: DateTimeKind.Local),

new DateTime(year: 1927, month: 10, day: 3, hour: 1, minute: 54, second: 42, millisecond: 158, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    450433491,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 450433491,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1951, month: 10, day: 13, hour: 6, minute: 52, second: 49, millisecond: 218, kind: DateTimeKind.Local),

new DateTime(year: 1995, month: 10, day: 3, hour: 13, minute: 48, second: 21, millisecond: 450, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 19, hour: 18, minute: 41, second: 35, millisecond: 52, kind: DateTimeKind.Local),

new DateTime(year: 1970, month: 10, day: 18, hour: 22, minute: 36, second: 45, millisecond: 729, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 12, second: 32, millisecond: 586, kind: DateTimeKind.Local),

new DateTime(year: 1980, month: 10, day: 5, hour: 22, minute: 19, second: 2, millisecond: 644, kind: DateTimeKind.Local),

new DateTime(year: 1943, month: 10, day: 7, hour: 13, minute: 1, second: 3, millisecond: 109, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 18, hour: 16, minute: 41, second: 29, millisecond: 300, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    485110016,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 485110016,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1986, month: 10, day: 19, hour: 10, minute: 53, second: 15, millisecond: 926, kind: DateTimeKind.Local),

new DateTime(year: 1925, month: 10, day: 11, hour: 4, minute: 7, second: 33, millisecond: 512, kind: DateTimeKind.Local),

new DateTime(year: 1973, month: 10, day: 10, hour: 14, minute: 12, second: 49, millisecond: 546, kind: DateTimeKind.Local),

new DateTime(year: 1928, month: 10, day: 2, hour: 7, minute: 43, second: 11, millisecond: 994, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1970, month: 10, day: 19, hour: 8, minute: 12, second: 29, millisecond: 706, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 17, hour: 17, minute: 3, second: 20, millisecond: 8, kind: DateTimeKind.Local),

new DateTime(year: 1923, month: 10, day: 8, hour: 1, minute: 32, second: 15, millisecond: 299, kind: DateTimeKind.Local),

new DateTime(year: 1951, month: 10, day: 9, hour: 8, minute: 53, second: 37, millisecond: 659, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    525726109,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 525726109,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1926, month: 10, day: 5, hour: 20, minute: 18, second: 41, millisecond: 289, kind: DateTimeKind.Local),

new DateTime(year: 1979, month: 10, day: 9, hour: 10, minute: 34, second: 41, millisecond: 229, kind: DateTimeKind.Local),

new DateTime(year: 1935, month: 10, day: 14, hour: 3, minute: 16, second: 14, millisecond: 508, kind: DateTimeKind.Local),

new DateTime(year: 1945, month: 10, day: 2, hour: 18, minute: 46, second: 36, millisecond: 256, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    892351305,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 892351305,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1946, month: 10, day: 9, hour: 19, minute: 44, second: 5, millisecond: 937, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 2, hour: 2, minute: 55, second: 21, millisecond: 91, kind: DateTimeKind.Local),

new DateTime(year: 1990, month: 10, day: 16, hour: 15, minute: 52, second: 8, millisecond: 489, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1996, month: 10, day: 1, hour: 8, minute: 28, second: 19, millisecond: 331, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 12, hour: 7, minute: 51, second: 55, millisecond: 138, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 24, second: 1, millisecond: 674, kind: DateTimeKind.Local),

new DateTime(year: 2005, month: 10, day: 4, hour: 8, minute: 39, second: 45, millisecond: 274, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    967936046,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 967936046,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1940, month: 10, day: 2, hour: 5, minute: 32, second: 28, millisecond: 515, kind: DateTimeKind.Local),

new DateTime(year: 1976, month: 10, day: 13, hour: 15, minute: 15, second: 14, millisecond: 216, kind: DateTimeKind.Local),

new DateTime(year: 1998, month: 10, day: 16, hour: 16, minute: 39, second: 14, millisecond: 737, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1274823456,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1274823456,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 1, hour: 2, minute: 33, second: 12, millisecond: 374, kind: DateTimeKind.Local),

new DateTime(year: 2010, month: 10, day: 4, hour: 13, minute: 18, second: 45, millisecond: 423, kind: DateTimeKind.Local),

new DateTime(year: 2002, month: 10, day: 6, hour: 5, minute: 38, second: 38, millisecond: 118, kind: DateTimeKind.Local),

new DateTime(year: 1957, month: 10, day: 14, hour: 9, minute: 16, second: 21, millisecond: 392, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 2016, month: 10, day: 18, hour: 17, minute: 1, second: 54, millisecond: 90, kind: DateTimeKind.Local),

new DateTime(year: 1996, month: 10, day: 7, hour: 21, minute: 36, second: 53, millisecond: 868, kind: DateTimeKind.Local),

new DateTime(year: 1963, month: 10, day: 9, hour: 7, minute: 8, second: 16, millisecond: 564, kind: DateTimeKind.Local),

new DateTime(year: 1958, month: 10, day: 9, hour: 18, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1330617629,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1330617629,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1967, month: 10, day: 8, hour: 15, minute: 21, second: 41, millisecond: 591, kind: DateTimeKind.Local),

new DateTime(year: 1950, month: 10, day: 1, hour: 21, minute: 42, second: 43, millisecond: 531, kind: DateTimeKind.Local),

new DateTime(year: 1917, month: 10, day: 14, hour: 22, minute: 9, second: 25, millisecond: 342, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1348122569,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1348122569,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1920, month: 10, day: 18, hour: 17, minute: 46, second: 37, millisecond: 984, kind: DateTimeKind.Local),

new DateTime(year: 1954, month: 10, day: 1, hour: 13, minute: 39, second: 3, millisecond: 963, kind: DateTimeKind.Local),

new DateTime(year: 1982, month: 10, day: 11, hour: 13, minute: 39, second: 26, millisecond: 352, kind: DateTimeKind.Local),

new DateTime(year: 1959, month: 10, day: 19, hour: 19, minute: 36, second: 16, millisecond: 867, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[3]
{
new DateTime(year: 1973, month: 10, day: 1, hour: 20, minute: 37, second: 19, millisecond: 679, kind: DateTimeKind.Local),

new DateTime(year: 1981, month: 10, day: 12, hour: 2, minute: 11, second: 49, millisecond: 777, kind: DateTimeKind.Local),

new DateTime(year: 1961, month: 10, day: 14, hour: 16, minute: 5, second: 57, millisecond: 623, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1451416793,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1451416793,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1977, month: 10, day: 6, hour: 19, minute: 50, second: 29, millisecond: 762, kind: DateTimeKind.Local),

new DateTime(year: 1920, month: 10, day: 5, hour: 18, minute: 6, second: 26, millisecond: 50, kind: DateTimeKind.Local),

new DateTime(year: 1953, month: 10, day: 17, hour: 4, minute: 50, second: 6, millisecond: 946, kind: DateTimeKind.Local),

},
                        NullableValue = 
new System.DateTime[4]
{
new DateTime(year: 1922, month: 10, day: 6, hour: 15, minute: 11, second: 25, millisecond: 260, kind: DateTimeKind.Local),

new DateTime(year: 1939, month: 10, day: 1, hour: 17, minute: 29, second: 47, millisecond: 350, kind: DateTimeKind.Local),

new DateTime(year: 1968, month: 10, day: 16, hour: 8, minute: 45, second: 43, millisecond: 220, kind: DateTimeKind.Local),

new DateTime(year: 2017, month: 10, day: 9, hour: 15, minute: 35, second: 32, millisecond: 610, kind: DateTimeKind.Local),

}
                    }
                );

                expected.Add(
                    1494950797,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1494950797,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1947, month: 10, day: 1, hour: 17, minute: 32, second: 33, millisecond: 346, kind: DateTimeKind.Local),

new DateTime(year: 1964, month: 10, day: 14, hour: 9, minute: 20, second: 31, millisecond: 72, kind: DateTimeKind.Local),

new DateTime(year: 1997, month: 10, day: 4, hour: 20, minute: 2, second: 53, millisecond: 584, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1743287547,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1743287547,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1943, month: 10, day: 8, hour: 2, minute: 18, second: 25, millisecond: 383, kind: DateTimeKind.Local),

new DateTime(year: 1972, month: 10, day: 14, hour: 22, minute: 28, second: 53, millisecond: 206, kind: DateTimeKind.Local),

new DateTime(year: 1988, month: 10, day: 8, hour: 9, minute: 9, second: 14, millisecond: 686, kind: DateTimeKind.Local),

new DateTime(year: 2015, month: 10, day: 7, hour: 5, minute: 28, second: 23, millisecond: 529, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1778035144,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1778035144,
                        Value = 
new System.DateTime[3]
{
new DateTime(year: 1961, month: 10, day: 6, hour: 4, minute: 55, second: 16, millisecond: 186, kind: DateTimeKind.Local),

new DateTime(year: 1947, month: 10, day: 19, hour: 18, minute: 4, second: 26, millisecond: 989, kind: DateTimeKind.Local),

new DateTime(year: 1946, month: 10, day: 15, hour: 6, minute: 22, second: 14, millisecond: 542, kind: DateTimeKind.Local),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1877988499,
                    new DateTimetimestamp_without_time_zoneArray1MI
                    {
                        Id = 1877988499,
                        Value = 
new System.DateTime[4]
{
new DateTime(year: 1964, month: 10, day: 1, hour: 10, minute: 20, second: 36, millisecond: 6, kind: DateTimeKind.Local),

new DateTime(year: 2006, month: 10, day: 17, hour: 17, minute: 17, second: 13, millisecond: 66, kind: DateTimeKind.Local),

new DateTime(year: 1952, month: 10, day: 6, hour: 5, minute: 30, second: 30, millisecond: 911, kind: DateTimeKind.Local),

new DateTime(year: 1944, month: 10, day: 17, hour: 11, minute: 44, second: 58, millisecond: 342, kind: DateTimeKind.Local),

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


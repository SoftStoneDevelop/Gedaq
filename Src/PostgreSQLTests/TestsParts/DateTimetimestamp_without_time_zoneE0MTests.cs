

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
    internal partial interface IDateTimeSingleTypetimestamp_without_time_zone
    {
    }
    
    internal partial class DateTimeSingleTypetimestamp_without_time_zone : IDateTimeSingleTypetimestamp_without_time_zone
    {


#region TestData

        private readonly DateTimetimestamp_without_time_zoneE0M[] _testData = new DateTimetimestamp_without_time_zoneE0M[]
        {
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 7,
    Value = new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 11, second: 40, millisecond: 984, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 13,
    Value = new DateTime(year: 1966, month: 10, day: 15, hour: 16, minute: 18, second: 42, millisecond: 960, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 7,
    Value = new DateTime(year: 2017, month: 10, day: 13, hour: 11, minute: 57, second: 24, millisecond: 898, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1948, month: 10, day: 9, hour: 20, minute: 5, second: 53, millisecond: 991, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 19,
    Value = new DateTime(year: 1946, month: 10, day: 12, hour: 14, minute: 44, second: 29, millisecond: 385, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 12, hour: 8, minute: 9, second: 53, millisecond: 213, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 28,
    Value = new DateTime(year: 1988, month: 10, day: 17, hour: 3, minute: 20, second: 35, millisecond: 987, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 11,
    Value = new DateTime(year: 1925, month: 10, day: 11, hour: 19, minute: 9, second: 53, millisecond: 614, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1970, month: 10, day: 18, hour: 13, minute: 19, second: 23, millisecond: 935, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1934, month: 10, day: 13, hour: 1, minute: 19, second: 10, millisecond: 854, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 37,
    Value = new DateTime(year: 1932, month: 10, day: 7, hour: 5, minute: 1, second: 18, millisecond: 437, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2017, month: 10, day: 7, hour: 16, minute: 4, second: 30, millisecond: 222, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 45,
    Value = new DateTime(year: 1954, month: 10, day: 18, hour: 13, minute: 19, second: 20, millisecond: 840, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 20,
    Value = new DateTime(year: 1996, month: 10, day: 15, hour: 14, minute: 54, second: 50, millisecond: 995, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2006, month: 10, day: 10, hour: 14, minute: 36, second: 28, millisecond: 797, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1999, month: 10, day: 2, hour: 19, minute: 27, second: 40, millisecond: 893, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 52,
    Value = new DateTime(year: 1999, month: 10, day: 16, hour: 19, minute: 35, second: 56, millisecond: 996, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2004, month: 10, day: 19, hour: 17, minute: 15, second: 26, millisecond: 244, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 57,
    Value = new DateTime(year: 1982, month: 10, day: 6, hour: 9, minute: 23, second: 19, millisecond: 891, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 26,
    Value = new DateTime(year: 1996, month: 10, day: 1, hour: 6, minute: 41, second: 36, millisecond: 195, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2004, month: 10, day: 13, hour: 14, minute: 8, second: 42, millisecond: 258, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1963, month: 10, day: 3, hour: 12, minute: 23, second: 39, millisecond: 170, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 61,
    Value = new DateTime(year: 2005, month: 10, day: 2, hour: 2, minute: 39, second: 7, millisecond: 208, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 64,
    Value = new DateTime(year: 1995, month: 10, day: 4, hour: 22, minute: 21, second: 48, millisecond: 368, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 29,
    Value = new DateTime(year: 1959, month: 10, day: 18, hour: 20, minute: 11, second: 49, millisecond: 389, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 71,
    Value = new DateTime(year: 1955, month: 10, day: 16, hour: 20, minute: 14, second: 47, millisecond: 63, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1953, month: 10, day: 11, hour: 10, minute: 56, second: 7, millisecond: 956, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 74,
    Value = new DateTime(year: 1962, month: 10, day: 1, hour: 19, minute: 37, second: 27, millisecond: 966, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 33,
    Value = new DateTime(year: 2007, month: 10, day: 11, hour: 22, minute: 49, second: 37, millisecond: 661, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 83,
    Value = new DateTime(year: 1992, month: 10, day: 15, hour: 20, minute: 36, second: 23, millisecond: 726, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 86,
    Value = new DateTime(year: 1964, month: 10, day: 13, hour: 15, minute: 46, second: 11, millisecond: 782, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 36,
    Value = new DateTime(year: 1994, month: 10, day: 1, hour: 3, minute: 12, second: 57, millisecond: 979, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1980, month: 10, day: 8, hour: 21, minute: 25, second: 4, millisecond: 926, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 87,
    Value = new DateTime(year: 2008, month: 10, day: 9, hour: 17, minute: 18, second: 55, millisecond: 29, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1948, month: 10, day: 13, hour: 11, minute: 50, second: 21, millisecond: 368, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 90,
    Value = new DateTime(year: 1996, month: 10, day: 2, hour: 18, minute: 37, second: 48, millisecond: 716, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 42,
    Value = new DateTime(year: 1920, month: 10, day: 11, hour: 19, minute: 32, second: 30, millisecond: 171, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2009, month: 10, day: 11, hour: 21, minute: 28, second: 32, millisecond: 437, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 95,
    Value = new DateTime(year: 1971, month: 10, day: 14, hour: 15, minute: 13, second: 21, millisecond: 260, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 100,
    Value = new DateTime(year: 1943, month: 10, day: 12, hour: 16, minute: 21, second: 35, millisecond: 26, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 44,
    Value = new DateTime(year: 1971, month: 10, day: 1, hour: 2, minute: 48, second: 7, millisecond: 273, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1980, month: 10, day: 14, hour: 2, minute: 7, second: 9, millisecond: 929, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1943, month: 10, day: 11, hour: 14, minute: 43, second: 20, millisecond: 137, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 106,
    Value = new DateTime(year: 1930, month: 10, day: 12, hour: 4, minute: 24, second: 16, millisecond: 711, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1989, month: 10, day: 5, hour: 15, minute: 1, second: 29, millisecond: 140, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 114,
    Value = new DateTime(year: 1988, month: 10, day: 12, hour: 16, minute: 49, second: 17, millisecond: 722, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 48,
    Value = new DateTime(year: 1985, month: 10, day: 16, hour: 4, minute: 35, second: 58, millisecond: 946, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1921, month: 10, day: 1, hour: 7, minute: 4, second: 9, millisecond: 403, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 116,
    Value = new DateTime(year: 1982, month: 10, day: 7, hour: 4, minute: 24, second: 46, millisecond: 491, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1963, month: 10, day: 3, hour: 21, minute: 14, second: 21, millisecond: 855, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 117,
    Value = new DateTime(year: 1996, month: 10, day: 11, hour: 6, minute: 18, second: 3, millisecond: 813, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 54,
    Value = new DateTime(year: 2002, month: 10, day: 17, hour: 1, minute: 16, second: 16, millisecond: 884, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2007, month: 10, day: 13, hour: 7, minute: 1, second: 34, millisecond: 895, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 119,
    Value = new DateTime(year: 2005, month: 10, day: 4, hour: 20, minute: 49, second: 15, millisecond: 417, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 2, hour: 15, minute: 30, second: 51, millisecond: 196, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 125,
    Value = new DateTime(year: 1921, month: 10, day: 10, hour: 14, minute: 36, second: 49, millisecond: 335, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 63,
    Value = new DateTime(year: 1932, month: 10, day: 5, hour: 6, minute: 58, second: 55, millisecond: 622, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1941, month: 10, day: 1, hour: 21, minute: 2, second: 13, millisecond: 31, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 127,
    Value = new DateTime(year: 1969, month: 10, day: 13, hour: 13, minute: 50, second: 8, millisecond: 392, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1994, month: 10, day: 5, hour: 17, minute: 18, second: 23, millisecond: 679, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 134,
    Value = new DateTime(year: 1944, month: 10, day: 5, hour: 4, minute: 45, second: 22, millisecond: 592, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 64,
    Value = new DateTime(year: 2004, month: 10, day: 13, hour: 6, minute: 22, second: 56, millisecond: 447, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1924, month: 10, day: 17, hour: 22, minute: 56, second: 28, millisecond: 979, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 137,
    Value = new DateTime(year: 2005, month: 10, day: 5, hour: 9, minute: 10, second: 10, millisecond: 314, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 145,
    Value = new DateTime(year: 1988, month: 10, day: 14, hour: 8, minute: 4, second: 47, millisecond: 64, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 68,
    Value = new DateTime(year: 1936, month: 10, day: 11, hour: 17, minute: 18, second: 37, millisecond: 555, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1988, month: 10, day: 11, hour: 17, minute: 24, second: 48, millisecond: 816, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 154,
    Value = new DateTime(year: 2013, month: 10, day: 1, hour: 4, minute: 18, second: 9, millisecond: 374, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 160,
    Value = new DateTime(year: 1965, month: 10, day: 16, hour: 22, minute: 1, second: 14, millisecond: 761, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 70,
    Value = new DateTime(year: 2002, month: 10, day: 1, hour: 6, minute: 36, second: 58, millisecond: 818, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1941, month: 10, day: 9, hour: 5, minute: 25, second: 37, millisecond: 837, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 161,
    Value = new DateTime(year: 1957, month: 10, day: 5, hour: 22, minute: 13, second: 35, millisecond: 529, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 169,
    Value = new DateTime(year: 1988, month: 10, day: 15, hour: 22, minute: 57, second: 14, millisecond: 63, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 78,
    Value = new DateTime(year: 1928, month: 10, day: 10, hour: 17, minute: 13, second: 39, millisecond: 801, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2007, month: 10, day: 12, hour: 6, minute: 24, second: 44, millisecond: 124, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 172,
    Value = new DateTime(year: 2017, month: 10, day: 14, hour: 13, minute: 45, second: 27, millisecond: 417, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 178,
    Value = new DateTime(year: 1980, month: 10, day: 15, hour: 21, minute: 6, second: 15, millisecond: 332, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zoneE0MI
{
    Id = 87,
    Value = new DateTime(year: 1996, month: 10, day: 2, hour: 3, minute: 11, second: 51, millisecond: 500, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zoneE0M
{
    Id = 179,
    Value = new DateTime(year: 1961, month: 10, day: 15, hour: 1, minute: 8, second: 17, millisecond: 440, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21))]
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

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(26)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(26), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonee0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonee0mi_id", 
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
                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonee0mi_id
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
    datetimetimestamp_without_time_zonee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
                System.DateTime? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
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

                    nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 7, hour: 16, minute: 4, second: 30, millisecond: 222, kind: DateTimeKind.Local)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
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

                    nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 2, hour: 19, minute: 27, second: 40, millisecond: 893, kind: DateTimeKind.Local)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
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

                    nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 19, hour: 17, minute: 15, second: 26, millisecond: 244, kind: DateTimeKind.Local)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(21);
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

                    nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 3, hour: 12, minute: 23, second: 39, millisecond: 170, kind: DateTimeKind.Local)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonee0mi_id
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
    datetimetimestamp_without_time_zonee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zonee0mi_id", 
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
                System.DateTime? nullable = null;
                nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;
                nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 11, hour: 10, minute: 56, second: 7, millisecond: 956, kind: DateTimeKind.Local)));
                nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneE0M> models = null;

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zoneE0M> models = null;

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zonee0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zonee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimetimestamp_without_time_zonee0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(26)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(26),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimetimestamp_without_time_zonee0mi_id", 
                methodParametrName: "datetimetimestamp_without_time_zonee0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M), typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M), typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M), typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[28],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[29],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[30],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[31],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[32],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M), typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[24],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 169, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
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
FROM public.datetimetimestamp_without_time_zonee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_without_time_zoneE0M>();
                 ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDateTimetimestamp_without_time_zoneE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
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
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[12], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[13], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[14], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[15], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[16], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[17], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[18], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[19], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[20], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSTSelectModelBatch(connection, 19, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[3], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[4], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[5], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[6], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[7], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[8], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[9], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[10], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[11], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[12], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[13], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[14], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[15], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[16], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[17], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[18], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[19], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[20], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[24],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[25],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[26],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[27],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[28],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[29],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[30],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[11], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[12], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[13], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[14], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[15], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[16], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[17], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[18], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[19], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[20], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[21], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[22], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[23], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[24], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[25], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[26], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[27], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[28], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[29], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[30], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[31], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[32], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[33], false);
                        DateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[26], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[27], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[28], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[29], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[30], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[31], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[32], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[33], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[0],_testData[8], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[1],_testData[9], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[2],_testData[10], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[3],_testData[11], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[4],_testData[12], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[5],_testData[13], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[6],_testData[14], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[7],_testData[15], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[8],_testData[16], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[9],_testData[17], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[10],_testData[18], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[11],_testData[19], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[12],_testData[20], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[13],_testData[21], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[14],_testData[22], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[15],_testData[23], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[16],_testData[24], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[17],_testData[25], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[18],_testData[26], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[19],_testData[27], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[20],_testData[28], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[21],_testData[29], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[22],_testData[30], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[23],_testData[31], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[24],_testData[32], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[25],_testData[33], false);
                DateTimetimestamp_without_time_zoneE0M.AssertModel(models[26],_testData[34], false);
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
FROM public.datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 11, second: 40, millisecond: 984, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 15, hour: 16, minute: 18, second: 42, millisecond: 960, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 13, hour: 11, minute: 57, second: 24, millisecond: 898, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 9, hour: 20, minute: 5, second: 53, millisecond: 991, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 12, hour: 14, minute: 44, second: 29, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 12, hour: 8, minute: 9, second: 53, millisecond: 213, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 17, hour: 3, minute: 20, second: 35, millisecond: 987, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 11, hour: 19, minute: 9, second: 53, millisecond: 614, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 18, hour: 13, minute: 19, second: 23, millisecond: 935, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 13, hour: 1, minute: 19, second: 10, millisecond: 854, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 7, hour: 5, minute: 1, second: 18, millisecond: 437, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 7, hour: 16, minute: 4, second: 30, millisecond: 222, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 13, minute: 19, second: 20, millisecond: 840, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 15, hour: 14, minute: 54, second: 50, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 10, hour: 14, minute: 36, second: 28, millisecond: 797, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 2, hour: 19, minute: 27, second: 40, millisecond: 893, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 16, hour: 19, minute: 35, second: 56, millisecond: 996, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 19, hour: 17, minute: 15, second: 26, millisecond: 244, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 6, hour: 9, minute: 23, second: 19, millisecond: 891, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 1, hour: 6, minute: 41, second: 36, millisecond: 195, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 13, hour: 14, minute: 8, second: 42, millisecond: 258, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 3, hour: 12, minute: 23, second: 39, millisecond: 170, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 2, hour: 2, minute: 39, second: 7, millisecond: 208, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 4, hour: 22, minute: 21, second: 48, millisecond: 368, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 18, hour: 20, minute: 11, second: 49, millisecond: 389, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 20, minute: 14, second: 47, millisecond: 63, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 11, hour: 10, minute: 56, second: 7, millisecond: 956, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 1, hour: 19, minute: 37, second: 27, millisecond: 966, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 11, hour: 22, minute: 49, second: 37, millisecond: 661, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 15, hour: 20, minute: 36, second: 23, millisecond: 726, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 13, hour: 15, minute: 46, second: 11, millisecond: 782, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 1, hour: 3, minute: 12, second: 57, millisecond: 979, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 21, minute: 25, second: 4, millisecond: 926, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 9, hour: 17, minute: 18, second: 55, millisecond: 29, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 13, hour: 11, minute: 50, second: 21, millisecond: 368, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 18, minute: 37, second: 48, millisecond: 716, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 11, hour: 19, minute: 32, second: 30, millisecond: 171, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 11, hour: 21, minute: 28, second: 32, millisecond: 437, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 14, hour: 15, minute: 13, second: 21, millisecond: 260, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 12, hour: 16, minute: 21, second: 35, millisecond: 26, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 1, hour: 2, minute: 48, second: 7, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 14, hour: 2, minute: 7, second: 9, millisecond: 929, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 11, hour: 14, minute: 43, second: 20, millisecond: 137, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 12, hour: 4, minute: 24, second: 16, millisecond: 711, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 5, hour: 15, minute: 1, second: 29, millisecond: 140, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 16, minute: 49, second: 17, millisecond: 722, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 16, hour: 4, minute: 35, second: 58, millisecond: 946, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 1, hour: 7, minute: 4, second: 9, millisecond: 403, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 7, hour: 4, minute: 24, second: 46, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 3, hour: 21, minute: 14, second: 21, millisecond: 855, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 11, hour: 6, minute: 18, second: 3, millisecond: 813, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 17, hour: 1, minute: 16, second: 16, millisecond: 884, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 13, hour: 7, minute: 1, second: 34, millisecond: 895, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 4, hour: 20, minute: 49, second: 15, millisecond: 417, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 2, hour: 15, minute: 30, second: 51, millisecond: 196, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 10, hour: 14, minute: 36, second: 49, millisecond: 335, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 5, hour: 6, minute: 58, second: 55, millisecond: 622, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 1, hour: 21, minute: 2, second: 13, millisecond: 31, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 13, minute: 50, second: 8, millisecond: 392, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 5, hour: 17, minute: 18, second: 23, millisecond: 679, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 5, hour: 4, minute: 45, second: 22, millisecond: 592, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 13, hour: 6, minute: 22, second: 56, millisecond: 447, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 17, hour: 22, minute: 56, second: 28, millisecond: 979, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 5, hour: 9, minute: 10, second: 10, millisecond: 314, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 14, hour: 8, minute: 4, second: 47, millisecond: 64, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 11, hour: 17, minute: 18, second: 37, millisecond: 555, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 11, hour: 17, minute: 24, second: 48, millisecond: 816, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 1, hour: 4, minute: 18, second: 9, millisecond: 374, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 16, hour: 22, minute: 1, second: 14, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 1, hour: 6, minute: 36, second: 58, millisecond: 818, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 9, hour: 5, minute: 25, second: 37, millisecond: 837, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 22, minute: 13, second: 35, millisecond: 529, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 15, hour: 22, minute: 57, second: 14, millisecond: 63, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 10, hour: 17, minute: 13, second: 39, millisecond: 801, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 12, hour: 6, minute: 24, second: 44, millisecond: 124, kind: DateTimeKind.Local))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 14, hour: 13, minute: 45, second: 27, millisecond: 417, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 15, hour: 21, minute: 6, second: 15, millisecond: 332, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 3, minute: 11, second: 51, millisecond: 500, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 15, hour: 1, minute: 8, second: 17, millisecond: 440, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 11, second: 40, millisecond: 984, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 15, hour: 16, minute: 18, second: 42, millisecond: 960, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 13, hour: 11, minute: 57, second: 24, millisecond: 898, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 9, hour: 20, minute: 5, second: 53, millisecond: 991, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 12, hour: 14, minute: 44, second: 29, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 12, hour: 8, minute: 9, second: 53, millisecond: 213, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 17, hour: 3, minute: 20, second: 35, millisecond: 987, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 11, hour: 19, minute: 9, second: 53, millisecond: 614, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 18, hour: 13, minute: 19, second: 23, millisecond: 935, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 13, hour: 1, minute: 19, second: 10, millisecond: 854, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 7, hour: 5, minute: 1, second: 18, millisecond: 437, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 7, hour: 16, minute: 4, second: 30, millisecond: 222, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 13, minute: 19, second: 20, millisecond: 840, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 15, hour: 14, minute: 54, second: 50, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 10, hour: 14, minute: 36, second: 28, millisecond: 797, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 2, hour: 19, minute: 27, second: 40, millisecond: 893, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 16, hour: 19, minute: 35, second: 56, millisecond: 996, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 19, hour: 17, minute: 15, second: 26, millisecond: 244, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 6, hour: 9, minute: 23, second: 19, millisecond: 891, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 1, hour: 6, minute: 41, second: 36, millisecond: 195, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 13, hour: 14, minute: 8, second: 42, millisecond: 258, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 3, hour: 12, minute: 23, second: 39, millisecond: 170, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 2, hour: 2, minute: 39, second: 7, millisecond: 208, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 4, hour: 22, minute: 21, second: 48, millisecond: 368, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 18, hour: 20, minute: 11, second: 49, millisecond: 389, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 20, minute: 14, second: 47, millisecond: 63, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 11, hour: 10, minute: 56, second: 7, millisecond: 956, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 1, hour: 19, minute: 37, second: 27, millisecond: 966, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 11, hour: 22, minute: 49, second: 37, millisecond: 661, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 15, hour: 20, minute: 36, second: 23, millisecond: 726, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 13, hour: 15, minute: 46, second: 11, millisecond: 782, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 1, hour: 3, minute: 12, second: 57, millisecond: 979, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 21, minute: 25, second: 4, millisecond: 926, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 9, hour: 17, minute: 18, second: 55, millisecond: 29, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 13, hour: 11, minute: 50, second: 21, millisecond: 368, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 18, minute: 37, second: 48, millisecond: 716, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 11, hour: 19, minute: 32, second: 30, millisecond: 171, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 11, hour: 21, minute: 28, second: 32, millisecond: 437, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 14, hour: 15, minute: 13, second: 21, millisecond: 260, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 12, hour: 16, minute: 21, second: 35, millisecond: 26, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 1, hour: 2, minute: 48, second: 7, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 14, hour: 2, minute: 7, second: 9, millisecond: 929, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 11, hour: 14, minute: 43, second: 20, millisecond: 137, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 12, hour: 4, minute: 24, second: 16, millisecond: 711, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 5, hour: 15, minute: 1, second: 29, millisecond: 140, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 16, minute: 49, second: 17, millisecond: 722, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 16, hour: 4, minute: 35, second: 58, millisecond: 946, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 1, hour: 7, minute: 4, second: 9, millisecond: 403, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 7, hour: 4, minute: 24, second: 46, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 3, hour: 21, minute: 14, second: 21, millisecond: 855, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 11, hour: 6, minute: 18, second: 3, millisecond: 813, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 17, hour: 1, minute: 16, second: 16, millisecond: 884, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 13, hour: 7, minute: 1, second: 34, millisecond: 895, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 4, hour: 20, minute: 49, second: 15, millisecond: 417, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 2, hour: 15, minute: 30, second: 51, millisecond: 196, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 10, hour: 14, minute: 36, second: 49, millisecond: 335, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 5, hour: 6, minute: 58, second: 55, millisecond: 622, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 1, hour: 21, minute: 2, second: 13, millisecond: 31, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 13, minute: 50, second: 8, millisecond: 392, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 5, hour: 17, minute: 18, second: 23, millisecond: 679, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 5, hour: 4, minute: 45, second: 22, millisecond: 592, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 13, hour: 6, minute: 22, second: 56, millisecond: 447, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 17, hour: 22, minute: 56, second: 28, millisecond: 979, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 5, hour: 9, minute: 10, second: 10, millisecond: 314, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 14, hour: 8, minute: 4, second: 47, millisecond: 64, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 11, hour: 17, minute: 18, second: 37, millisecond: 555, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 11, hour: 17, minute: 24, second: 48, millisecond: 816, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 1, hour: 4, minute: 18, second: 9, millisecond: 374, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 16, hour: 22, minute: 1, second: 14, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 1, hour: 6, minute: 36, second: 58, millisecond: 818, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 9, hour: 5, minute: 25, second: 37, millisecond: 837, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 22, minute: 13, second: 35, millisecond: 529, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 15, hour: 22, minute: 57, second: 14, millisecond: 63, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 10, hour: 17, minute: 13, second: 39, millisecond: 801, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 12, hour: 6, minute: 24, second: 44, millisecond: 124, kind: DateTimeKind.Local))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 14, hour: 13, minute: 45, second: 27, millisecond: 417, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 15, hour: 21, minute: 6, second: 15, millisecond: 332, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 3, minute: 11, second: 51, millisecond: 500, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 15, hour: 1, minute: 8, second: 17, millisecond: 440, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_datetimetimestamp_without_time_zonee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeSingleTypetimestamp_without_time_zone)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_without_time_zonee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_without_time_zoneE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zonee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zoneE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
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
FROM public.binary_datetimetimestamp_without_time_zonee0m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zonee0mi mi ON mi.id = m.datetimetimestamp_without_time_zonee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DateTimetimestamp_without_time_zoneE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zonee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_without_time_zoneE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA), typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
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
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
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
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA), typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
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
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQueryExportModelInner(connection, @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
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
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MI), typeof(DateTimetimestamp_without_time_zoneE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MI>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MI>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MI>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_datetimetimestamp_without_time_zonee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA), typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                var models2 = new List<DateTimetimestamp_without_time_zoneE0MIWA>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zonee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zoneE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
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
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zoneE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


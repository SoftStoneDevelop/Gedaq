

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
    internal partial interface IDateTimeSingleTypetimestamp_with_time_zone
    {
    }
    
    internal partial class DateTimeSingleTypetimestamp_with_time_zone : IDateTimeSingleTypetimestamp_with_time_zone
    {


#region TestData

        private readonly DateTimetimestamp_with_time_zone0M[] _testData = new DateTimetimestamp_with_time_zone0M[]
        {
            new DateTimetimestamp_with_time_zone0M
{
    Id = 3,
    Value = new DateTime(year: 1980, month: 10, day: 8, hour: 19, minute: 16, second: 25, millisecond: 591, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1934, month: 10, day: 6, hour: 10, minute: 37, second: 49, millisecond: 480, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 11,
    Value = new DateTime(year: 1920, month: 10, day: 8, hour: 17, minute: 48, second: 31, millisecond: 766, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 5,
    Value = new DateTime(year: 1943, month: 10, day: 1, hour: 19, minute: 35, second: 20, millisecond: 659, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1940, month: 10, day: 2, hour: 16, minute: 16, second: 47, millisecond: 139, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 19,
    Value = new DateTime(year: 1992, month: 10, day: 6, hour: 22, minute: 38, second: 12, millisecond: 843, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 20,
    Value = new DateTime(year: 1943, month: 10, day: 9, hour: 11, minute: 20, second: 57, millisecond: 607, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 9,
    Value = new DateTime(year: 2005, month: 10, day: 3, hour: 7, minute: 47, second: 6, millisecond: 370, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1919, month: 10, day: 7, hour: 13, minute: 26, second: 46, millisecond: 945, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 26,
    Value = new DateTime(year: 1989, month: 10, day: 4, hour: 11, minute: 14, second: 32, millisecond: 628, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 31,
    Value = new DateTime(year: 1985, month: 10, day: 19, hour: 17, minute: 55, second: 42, millisecond: 880, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 14,
    Value = new DateTime(year: 2014, month: 10, day: 12, hour: 9, minute: 54, second: 58, millisecond: 793, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1966, month: 10, day: 16, hour: 3, minute: 52, second: 22, millisecond: 761, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 2007, month: 10, day: 14, hour: 12, minute: 58, second: 13, millisecond: 292, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 39,
    Value = new DateTime(year: 1929, month: 10, day: 5, hour: 1, minute: 43, second: 55, millisecond: 180, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1921, month: 10, day: 10, hour: 1, minute: 11, second: 11, millisecond: 477, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 41,
    Value = new DateTime(year: 1955, month: 10, day: 10, hour: 8, minute: 53, second: 14, millisecond: 517, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 18,
    Value = new DateTime(year: 1947, month: 10, day: 6, hour: 21, minute: 11, second: 37, millisecond: 345, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1921, month: 10, day: 6, hour: 5, minute: 23, second: 37, millisecond: 125, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 48,
    Value = new DateTime(year: 1995, month: 10, day: 6, hour: 14, minute: 24, second: 34, millisecond: 360, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1937, month: 10, day: 6, hour: 8, minute: 38, second: 9, millisecond: 113, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 54,
    Value = new DateTime(year: 2013, month: 10, day: 13, hour: 20, minute: 9, second: 21, millisecond: 635, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 26,
    Value = new DateTime(year: 2000, month: 10, day: 14, hour: 21, minute: 34, second: 3, millisecond: 546, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 3, second: 15, millisecond: 3, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 2001, month: 10, day: 2, hour: 13, minute: 20, second: 57, millisecond: 628, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 56,
    Value = new DateTime(year: 1973, month: 10, day: 10, hour: 22, minute: 8, second: 7, millisecond: 106, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 63,
    Value = new DateTime(year: 1948, month: 10, day: 19, hour: 10, minute: 51, second: 13, millisecond: 451, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 32,
    Value = new DateTime(year: 1944, month: 10, day: 19, hour: 3, minute: 23, second: 40, millisecond: 592, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1926, month: 10, day: 8, hour: 13, minute: 29, second: 53, millisecond: 503, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 71,
    Value = new DateTime(year: 1923, month: 10, day: 13, hour: 20, minute: 5, second: 58, millisecond: 498, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 72,
    Value = new DateTime(year: 2012, month: 10, day: 14, hour: 11, minute: 39, second: 11, millisecond: 395, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 35,
    Value = new DateTime(year: 2015, month: 10, day: 11, hour: 3, minute: 39, second: 44, millisecond: 764, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1980, month: 10, day: 9, hour: 11, minute: 24, second: 24, millisecond: 969, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 81,
    Value = new DateTime(year: 1972, month: 10, day: 8, hour: 14, minute: 57, second: 6, millisecond: 954, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1945, month: 10, day: 3, hour: 19, minute: 29, second: 18, millisecond: 934, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 87,
    Value = new DateTime(year: 1991, month: 10, day: 2, hour: 18, minute: 1, second: 8, millisecond: 213, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 39,
    Value = new DateTime(year: 1975, month: 10, day: 19, hour: 6, minute: 15, second: 37, millisecond: 143, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1933, month: 10, day: 1, hour: 15, minute: 34, second: 42, millisecond: 752, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1948, month: 10, day: 12, hour: 2, minute: 31, second: 11, millisecond: 658, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 93,
    Value = new DateTime(year: 1943, month: 10, day: 13, hour: 15, minute: 17, second: 23, millisecond: 298, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 2006, month: 10, day: 19, hour: 8, minute: 48, second: 51, millisecond: 725, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 102,
    Value = new DateTime(year: 2007, month: 10, day: 18, hour: 13, minute: 21, second: 22, millisecond: 863, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 44,
    Value = new DateTime(year: 1920, month: 10, day: 17, hour: 18, minute: 1, second: 49, millisecond: 315, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1982, month: 10, day: 17, hour: 1, minute: 53, second: 21, millisecond: 336, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1976, month: 10, day: 18, hour: 10, minute: 33, second: 18, millisecond: 816, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 110,
    Value = new DateTime(year: 1969, month: 10, day: 6, hour: 15, minute: 15, second: 17, millisecond: 568, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1923, month: 10, day: 17, hour: 8, minute: 8, second: 29, millisecond: 106, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 114,
    Value = new DateTime(year: 2011, month: 10, day: 19, hour: 8, minute: 5, second: 1, millisecond: 524, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 51,
    Value = new DateTime(year: 1921, month: 10, day: 19, hour: 22, minute: 50, second: 34, millisecond: 162, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1971, month: 10, day: 2, hour: 21, minute: 29, second: 56, millisecond: 776, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 117,
    Value = new DateTime(year: 1987, month: 10, day: 8, hour: 2, minute: 49, second: 12, millisecond: 59, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 124,
    Value = new DateTime(year: 1958, month: 10, day: 17, hour: 7, minute: 50, second: 6, millisecond: 602, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 54,
    Value = new DateTime(year: 1999, month: 10, day: 7, hour: 5, minute: 42, second: 22, millisecond: 981, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1970, month: 10, day: 2, hour: 7, minute: 42, second: 14, millisecond: 923, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 128,
    Value = new DateTime(year: 1924, month: 10, day: 6, hour: 20, minute: 49, second: 21, millisecond: 533, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 137,
    Value = new DateTime(year: 1960, month: 10, day: 8, hour: 20, minute: 11, second: 31, millisecond: 123, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 62,
    Value = new DateTime(year: 1950, month: 10, day: 10, hour: 4, minute: 51, second: 38, millisecond: 684, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 145,
    Value = new DateTime(year: 1983, month: 10, day: 11, hour: 20, minute: 16, second: 21, millisecond: 566, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1939, month: 10, day: 16, hour: 18, minute: 6, second: 12, millisecond: 60, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 149,
    Value = new DateTime(year: 1975, month: 10, day: 1, hour: 22, minute: 14, second: 23, millisecond: 973, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 67,
    Value = new DateTime(year: 1946, month: 10, day: 15, hour: 10, minute: 30, second: 9, millisecond: 12, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 151,
    Value = new DateTime(year: 2009, month: 10, day: 4, hour: 3, minute: 56, second: 36, millisecond: 332, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1933, month: 10, day: 3, hour: 22, minute: 37, second: 1, millisecond: 854, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 159,
    Value = new DateTime(year: 1974, month: 10, day: 2, hour: 19, minute: 38, second: 8, millisecond: 290, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 75,
    Value = new DateTime(year: 1995, month: 10, day: 7, hour: 6, minute: 51, second: 7, millisecond: 282, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 37, second: 4, millisecond: 917, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 2010, month: 10, day: 4, hour: 6, minute: 29, second: 52, millisecond: 327, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 160,
    Value = new DateTime(year: 1928, month: 10, day: 3, hour: 1, minute: 54, second: 35, millisecond: 165, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1933, month: 10, day: 10, hour: 21, minute: 8, second: 3, millisecond: 417, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 168,
    Value = new DateTime(year: 1976, month: 10, day: 1, hour: 7, minute: 2, second: 45, millisecond: 48, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 77,
    Value = new DateTime(year: 1924, month: 10, day: 15, hour: 22, minute: 56, second: 9, millisecond: 66, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26))]
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(6)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6), 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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
                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
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
    datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
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

                    nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
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

                    nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 12, minute: 58, second: 13, millisecond: 292, kind: DateTimeKind.Utc)));
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
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
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

                    nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1921, month: 10, day: 10, hour: 1, minute: 11, second: 11, millisecond: 477, kind: DateTimeKind.Utc)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.DateTime>();
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
                    ((NpgsqlParameter<System.DateTime>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(26);
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

                    nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
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
    datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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
                nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 6, hour: 8, minute: 38, second: 9, millisecond: 113, kind: DateTimeKind.Utc)));
                nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 2, hour: 13, minute: 20, second: 57, millisecond: 628, kind: DateTimeKind.Utc)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;
                nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zone0M> models = null;

                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_with_time_zone0M> models = null;

                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimetimestamp_with_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(6)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimetimestamp_with_time_zone0mi_id", 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M), typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M), typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M), typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 87;
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
                var models = await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[29], false);
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
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M), typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 41, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var firstItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 149, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
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
FROM public.datetimetimestamp_with_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems1 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                var secondItems2 = new List<FlatDateTimetimestamp_with_time_zone0M>();
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)),
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
                var models = await((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[29], false);
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
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_with_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelBatch(connection, 102, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[6], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[7], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[8], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[9], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[10], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[11], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[12], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[13], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[14], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[15], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[16], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[17], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[18], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[19], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[20], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[21], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[22], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[23], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[24], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[25], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[26], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[27], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[28], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[1], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[2], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[3], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[4], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[5], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[6], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[7], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[8], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[9], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[10], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[11], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[12], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[13], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[14], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[15], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[16], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[17], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[18], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[19], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[20], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[21], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[22], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[23], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[24], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[25], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[26], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[26],_testData[27], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[27],_testData[28], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[28],_testData[29], false);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 19, minute: 16, second: 25, millisecond: 591, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 10, minute: 37, second: 49, millisecond: 480, kind: DateTimeKind.Utc))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 8, hour: 17, minute: 48, second: 31, millisecond: 766, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 1, hour: 19, minute: 35, second: 20, millisecond: 659, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 2, hour: 16, minute: 16, second: 47, millisecond: 139, kind: DateTimeKind.Utc))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 6, hour: 22, minute: 38, second: 12, millisecond: 843, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 9, hour: 11, minute: 20, second: 57, millisecond: 607, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 3, hour: 7, minute: 47, second: 6, millisecond: 370, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 7, hour: 13, minute: 26, second: 46, millisecond: 945, kind: DateTimeKind.Utc))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 4, hour: 11, minute: 14, second: 32, millisecond: 628, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 19, hour: 17, minute: 55, second: 42, millisecond: 880, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 12, hour: 9, minute: 54, second: 58, millisecond: 793, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 16, hour: 3, minute: 52, second: 22, millisecond: 761, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 14, hour: 12, minute: 58, second: 13, millisecond: 292, kind: DateTimeKind.Utc))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 5, hour: 1, minute: 43, second: 55, millisecond: 180, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 10, hour: 1, minute: 11, second: 11, millisecond: 477, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 8, minute: 53, second: 14, millisecond: 517, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 6, hour: 21, minute: 11, second: 37, millisecond: 345, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 6, hour: 5, minute: 23, second: 37, millisecond: 125, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 6, hour: 14, minute: 24, second: 34, millisecond: 360, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 8, minute: 38, second: 9, millisecond: 113, kind: DateTimeKind.Utc))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 20, minute: 9, second: 21, millisecond: 635, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 14, hour: 21, minute: 34, second: 3, millisecond: 546, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 3, second: 15, millisecond: 3, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 13, minute: 20, second: 57, millisecond: 628, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 10, hour: 22, minute: 8, second: 7, millisecond: 106, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 19, hour: 10, minute: 51, second: 13, millisecond: 451, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 19, hour: 3, minute: 23, second: 40, millisecond: 592, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 8, hour: 13, minute: 29, second: 53, millisecond: 503, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 13, hour: 20, minute: 5, second: 58, millisecond: 498, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 14, hour: 11, minute: 39, second: 11, millisecond: 395, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 11, hour: 3, minute: 39, second: 44, millisecond: 764, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 9, hour: 11, minute: 24, second: 24, millisecond: 969, kind: DateTimeKind.Utc))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 8, hour: 14, minute: 57, second: 6, millisecond: 954, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 3, hour: 19, minute: 29, second: 18, millisecond: 934, kind: DateTimeKind.Utc))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 2, hour: 18, minute: 1, second: 8, millisecond: 213, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 19, hour: 6, minute: 15, second: 37, millisecond: 143, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 1, hour: 15, minute: 34, second: 42, millisecond: 752, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 12, hour: 2, minute: 31, second: 11, millisecond: 658, kind: DateTimeKind.Utc))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 13, hour: 15, minute: 17, second: 23, millisecond: 298, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 19, hour: 8, minute: 48, second: 51, millisecond: 725, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 18, hour: 13, minute: 21, second: 22, millisecond: 863, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 17, hour: 18, minute: 1, second: 49, millisecond: 315, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 1, minute: 53, second: 21, millisecond: 336, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 18, hour: 10, minute: 33, second: 18, millisecond: 816, kind: DateTimeKind.Utc))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 6, hour: 15, minute: 15, second: 17, millisecond: 568, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 17, hour: 8, minute: 8, second: 29, millisecond: 106, kind: DateTimeKind.Utc))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 19, hour: 8, minute: 5, second: 1, millisecond: 524, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 19, hour: 22, minute: 50, second: 34, millisecond: 162, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 2, hour: 21, minute: 29, second: 56, millisecond: 776, kind: DateTimeKind.Utc))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 2, minute: 49, second: 12, millisecond: 59, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 17, hour: 7, minute: 50, second: 6, millisecond: 602, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 7, hour: 5, minute: 42, second: 22, millisecond: 981, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 2, hour: 7, minute: 42, second: 14, millisecond: 923, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 6, hour: 20, minute: 49, second: 21, millisecond: 533, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 8, hour: 20, minute: 11, second: 31, millisecond: 123, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 10, hour: 4, minute: 51, second: 38, millisecond: 684, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 11, hour: 20, minute: 16, second: 21, millisecond: 566, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 16, hour: 18, minute: 6, second: 12, millisecond: 60, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 1, hour: 22, minute: 14, second: 23, millisecond: 973, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 15, hour: 10, minute: 30, second: 9, millisecond: 12, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 4, hour: 3, minute: 56, second: 36, millisecond: 332, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 3, hour: 22, minute: 37, second: 1, millisecond: 854, kind: DateTimeKind.Utc))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 2, hour: 19, minute: 38, second: 8, millisecond: 290, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 7, hour: 6, minute: 51, second: 7, millisecond: 282, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 37, second: 4, millisecond: 917, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 4, hour: 6, minute: 29, second: 52, millisecond: 327, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 3, hour: 1, minute: 54, second: 35, millisecond: 165, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 10, hour: 21, minute: 8, second: 3, millisecond: 417, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 1, hour: 7, minute: 2, second: 45, millisecond: 48, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 15, hour: 22, minute: 56, second: 9, millisecond: 66, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 19, minute: 16, second: 25, millisecond: 591, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 10, minute: 37, second: 49, millisecond: 480, kind: DateTimeKind.Utc))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 8, hour: 17, minute: 48, second: 31, millisecond: 766, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 1, hour: 19, minute: 35, second: 20, millisecond: 659, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 2, hour: 16, minute: 16, second: 47, millisecond: 139, kind: DateTimeKind.Utc))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 6, hour: 22, minute: 38, second: 12, millisecond: 843, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 9, hour: 11, minute: 20, second: 57, millisecond: 607, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 3, hour: 7, minute: 47, second: 6, millisecond: 370, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 7, hour: 13, minute: 26, second: 46, millisecond: 945, kind: DateTimeKind.Utc))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 4, hour: 11, minute: 14, second: 32, millisecond: 628, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 19, hour: 17, minute: 55, second: 42, millisecond: 880, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 12, hour: 9, minute: 54, second: 58, millisecond: 793, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 16, hour: 3, minute: 52, second: 22, millisecond: 761, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 14, hour: 12, minute: 58, second: 13, millisecond: 292, kind: DateTimeKind.Utc))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 5, hour: 1, minute: 43, second: 55, millisecond: 180, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 10, hour: 1, minute: 11, second: 11, millisecond: 477, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 8, minute: 53, second: 14, millisecond: 517, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 6, hour: 21, minute: 11, second: 37, millisecond: 345, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 6, hour: 5, minute: 23, second: 37, millisecond: 125, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 6, hour: 14, minute: 24, second: 34, millisecond: 360, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 8, minute: 38, second: 9, millisecond: 113, kind: DateTimeKind.Utc))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 20, minute: 9, second: 21, millisecond: 635, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 14, hour: 21, minute: 34, second: 3, millisecond: 546, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 3, second: 15, millisecond: 3, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 13, minute: 20, second: 57, millisecond: 628, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 10, hour: 22, minute: 8, second: 7, millisecond: 106, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 19, hour: 10, minute: 51, second: 13, millisecond: 451, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 19, hour: 3, minute: 23, second: 40, millisecond: 592, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 8, hour: 13, minute: 29, second: 53, millisecond: 503, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 13, hour: 20, minute: 5, second: 58, millisecond: 498, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 14, hour: 11, minute: 39, second: 11, millisecond: 395, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 11, hour: 3, minute: 39, second: 44, millisecond: 764, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 9, hour: 11, minute: 24, second: 24, millisecond: 969, kind: DateTimeKind.Utc))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 8, hour: 14, minute: 57, second: 6, millisecond: 954, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 3, hour: 19, minute: 29, second: 18, millisecond: 934, kind: DateTimeKind.Utc))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 2, hour: 18, minute: 1, second: 8, millisecond: 213, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 19, hour: 6, minute: 15, second: 37, millisecond: 143, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 1, hour: 15, minute: 34, second: 42, millisecond: 752, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 12, hour: 2, minute: 31, second: 11, millisecond: 658, kind: DateTimeKind.Utc))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 13, hour: 15, minute: 17, second: 23, millisecond: 298, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 19, hour: 8, minute: 48, second: 51, millisecond: 725, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 18, hour: 13, minute: 21, second: 22, millisecond: 863, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 17, hour: 18, minute: 1, second: 49, millisecond: 315, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 1, minute: 53, second: 21, millisecond: 336, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 18, hour: 10, minute: 33, second: 18, millisecond: 816, kind: DateTimeKind.Utc))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 6, hour: 15, minute: 15, second: 17, millisecond: 568, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 17, hour: 8, minute: 8, second: 29, millisecond: 106, kind: DateTimeKind.Utc))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 19, hour: 8, minute: 5, second: 1, millisecond: 524, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 19, hour: 22, minute: 50, second: 34, millisecond: 162, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 2, hour: 21, minute: 29, second: 56, millisecond: 776, kind: DateTimeKind.Utc))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 2, minute: 49, second: 12, millisecond: 59, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 17, hour: 7, minute: 50, second: 6, millisecond: 602, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 7, hour: 5, minute: 42, second: 22, millisecond: 981, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 2, hour: 7, minute: 42, second: 14, millisecond: 923, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 6, hour: 20, minute: 49, second: 21, millisecond: 533, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 8, hour: 20, minute: 11, second: 31, millisecond: 123, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 10, hour: 4, minute: 51, second: 38, millisecond: 684, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 11, hour: 20, minute: 16, second: 21, millisecond: 566, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 16, hour: 18, minute: 6, second: 12, millisecond: 60, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 1, hour: 22, minute: 14, second: 23, millisecond: 973, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 15, hour: 10, minute: 30, second: 9, millisecond: 12, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 4, hour: 3, minute: 56, second: 36, millisecond: 332, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 3, hour: 22, minute: 37, second: 1, millisecond: 854, kind: DateTimeKind.Utc))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 2, hour: 19, minute: 38, second: 8, millisecond: 290, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 7, hour: 6, minute: 51, second: 7, millisecond: 282, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 37, second: 4, millisecond: 917, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 4, hour: 6, minute: 29, second: 52, millisecond: 327, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 3, hour: 1, minute: 54, second: 35, millisecond: 165, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 10, hour: 21, minute: 8, second: 3, millisecond: 417, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 1, hour: 7, minute: 2, second: 45, millisecond: 48, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 15, hour: 22, minute: 56, second: 9, millisecond: 66, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
FROM public.binary_datetimetimestamp_with_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(26)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zone0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zone0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zone0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateTimetimestamp_with_time_zone0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_datetimetimestamp_with_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(26)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateTimetimestamp_with_time_zone0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateTimetimestamp_with_time_zone0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
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
FROM public.binary_datetimetimestamp_with_time_zone0m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zone0M>(15);

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
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_with_time_zone0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateTimetimestamp_with_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_with_time_zone0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(26)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


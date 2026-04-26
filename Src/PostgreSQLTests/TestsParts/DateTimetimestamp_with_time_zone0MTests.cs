

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
    Id = 4,
    Value = new DateTime(year: 1961, month: 10, day: 6, hour: 5, minute: 56, second: 57, millisecond: 216, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 12,
    Value = new DateTime(year: 2007, month: 10, day: 8, hour: 19, minute: 49, second: 12, millisecond: 150, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 3,
    Value = new DateTime(year: 2000, month: 10, day: 18, hour: 18, minute: 22, second: 25, millisecond: 93, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1952, month: 10, day: 17, hour: 15, minute: 16, second: 31, millisecond: 649, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 18,
    Value = new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 15, second: 44, millisecond: 346, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1984, month: 10, day: 15, hour: 17, minute: 22, second: 20, millisecond: 258, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 20,
    Value = new DateTime(year: 1943, month: 10, day: 6, hour: 21, minute: 58, second: 24, millisecond: 725, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 10,
    Value = new DateTime(year: 2002, month: 10, day: 5, hour: 4, minute: 53, second: 31, millisecond: 708, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1921, month: 10, day: 13, hour: 5, minute: 31, second: 36, millisecond: 91, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 28,
    Value = new DateTime(year: 1982, month: 10, day: 7, hour: 3, minute: 24, second: 3, millisecond: 434, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1936, month: 10, day: 4, hour: 8, minute: 12, second: 30, millisecond: 709, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 30,
    Value = new DateTime(year: 1942, month: 10, day: 17, hour: 5, minute: 43, second: 49, millisecond: 3, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 17,
    Value = new DateTime(year: 1969, month: 10, day: 13, hour: 21, minute: 51, second: 48, millisecond: 359, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1998, month: 10, day: 10, hour: 17, minute: 8, second: 33, millisecond: 973, kind: DateTimeKind.Utc),
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 36,
    Value = new DateTime(year: 1971, month: 10, day: 1, hour: 18, minute: 29, second: 25, millisecond: 982, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1996, month: 10, day: 8, hour: 5, minute: 45, second: 1, millisecond: 901, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 38,
    Value = new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 3, second: 19, millisecond: 12, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 19,
    Value = new DateTime(year: 1942, month: 10, day: 11, hour: 4, minute: 36, second: 30, millisecond: 445, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1925, month: 10, day: 5, hour: 22, minute: 28, second: 23, millisecond: 775, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 43,
    Value = new DateTime(year: 1968, month: 10, day: 2, hour: 12, minute: 36, second: 15, millisecond: 2, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 51,
    Value = new DateTime(year: 1930, month: 10, day: 10, hour: 2, minute: 52, second: 31, millisecond: 534, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 25,
    Value = new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 54, second: 51, millisecond: 44, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1979, month: 10, day: 10, hour: 5, minute: 55, second: 21, millisecond: 431, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 60,
    Value = new DateTime(year: 1976, month: 10, day: 16, hour: 20, minute: 14, second: 16, millisecond: 222, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 2017, month: 10, day: 16, hour: 21, minute: 54, second: 4, millisecond: 913, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 64,
    Value = new DateTime(year: 1930, month: 10, day: 16, hour: 11, minute: 19, second: 58, millisecond: 757, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 30,
    Value = new DateTime(year: 2000, month: 10, day: 5, hour: 6, minute: 7, second: 15, millisecond: 45, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1986, month: 10, day: 4, hour: 19, minute: 45, second: 38, millisecond: 623, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1937, month: 10, day: 5, hour: 15, minute: 57, second: 54, millisecond: 805, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 70,
    Value = new DateTime(year: 1988, month: 10, day: 9, hour: 2, minute: 40, second: 54, millisecond: 558, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1925, month: 10, day: 5, hour: 9, minute: 54, second: 53, millisecond: 128, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 72,
    Value = new DateTime(year: 2012, month: 10, day: 16, hour: 1, minute: 13, second: 30, millisecond: 749, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 32,
    Value = new DateTime(year: 1947, month: 10, day: 3, hour: 18, minute: 22, second: 7, millisecond: 414, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1984, month: 10, day: 9, hour: 7, minute: 32, second: 57, millisecond: 743, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1932, month: 10, day: 1, hour: 11, minute: 26, second: 4, millisecond: 509, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 81,
    Value = new DateTime(year: 1937, month: 10, day: 5, hour: 21, minute: 17, second: 1, millisecond: 840, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 89,
    Value = new DateTime(year: 1976, month: 10, day: 13, hour: 11, minute: 50, second: 23, millisecond: 365, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 35,
    Value = new DateTime(year: 2016, month: 10, day: 4, hour: 13, minute: 51, second: 44, millisecond: 338, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1944, month: 10, day: 16, hour: 14, minute: 29, second: 37, millisecond: 477, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 2017, month: 10, day: 14, hour: 19, minute: 29, second: 22, millisecond: 257, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 92,
    Value = new DateTime(year: 1931, month: 10, day: 16, hour: 8, minute: 42, second: 27, millisecond: 925, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1973, month: 10, day: 17, hour: 11, minute: 38, second: 12, millisecond: 322, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 100,
    Value = new DateTime(year: 1946, month: 10, day: 19, hour: 15, minute: 27, second: 19, millisecond: 922, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 38,
    Value = new DateTime(year: 1952, month: 10, day: 17, hour: 17, minute: 51, second: 34, millisecond: 211, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 101,
    Value = new DateTime(year: 1950, month: 10, day: 5, hour: 9, minute: 4, second: 36, millisecond: 267, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 106,
    Value = new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 4, second: 20, millisecond: 960, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 43,
    Value = new DateTime(year: 1965, month: 10, day: 14, hour: 8, minute: 12, second: 40, millisecond: 224, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 110,
    Value = new DateTime(year: 1924, month: 10, day: 14, hour: 5, minute: 50, second: 38, millisecond: 879, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1928, month: 10, day: 9, hour: 11, minute: 2, second: 15, millisecond: 735, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 117,
    Value = new DateTime(year: 1940, month: 10, day: 1, hour: 4, minute: 29, second: 36, millisecond: 160, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 48,
    Value = new DateTime(year: 2010, month: 10, day: 4, hour: 9, minute: 7, second: 27, millisecond: 100, kind: DateTimeKind.Utc),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 126,
    Value = new DateTime(year: 1919, month: 10, day: 12, hour: 2, minute: 56, second: 9, millisecond: 288, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1961, month: 10, day: 11, hour: 18, minute: 48, second: 3, millisecond: 380, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 127,
    Value = new DateTime(year: 1999, month: 10, day: 14, hour: 16, minute: 42, second: 34, millisecond: 335, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 50,
    Value = new DateTime(year: 1944, month: 10, day: 11, hour: 11, minute: 51, second: 57, millisecond: 453, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 2014, month: 10, day: 11, hour: 12, minute: 50, second: 43, millisecond: 474, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1920, month: 10, day: 16, hour: 14, minute: 45, second: 21, millisecond: 34, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 132,
    Value = new DateTime(year: 2002, month: 10, day: 9, hour: 19, minute: 23, second: 49, millisecond: 599, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 2016, month: 10, day: 4, hour: 7, minute: 19, second: 31, millisecond: 75, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 136,
    Value = new DateTime(year: 2003, month: 10, day: 3, hour: 10, minute: 18, second: 44, millisecond: 302, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 58,
    Value = new DateTime(year: 1960, month: 10, day: 4, hour: 17, minute: 54, second: 2, millisecond: 75, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1986, month: 10, day: 1, hour: 11, minute: 47, second: 43, millisecond: 27, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1931, month: 10, day: 15, hour: 22, minute: 20, second: 42, millisecond: 313, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 144,
    Value = new DateTime(year: 1980, month: 10, day: 1, hour: 19, minute: 24, second: 5, millisecond: 68, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 153,
    Value = new DateTime(year: 1971, month: 10, day: 16, hour: 5, minute: 55, second: 51, millisecond: 996, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 60,
    Value = new DateTime(year: 1927, month: 10, day: 5, hour: 10, minute: 20, second: 37, millisecond: 510, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1948, month: 10, day: 3, hour: 20, minute: 22, second: 44, millisecond: 934, kind: DateTimeKind.Utc),
},
    NullableValue = new DateTime(year: 1944, month: 10, day: 4, hour: 21, minute: 23, second: 56, millisecond: 237, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 160,
    Value = new DateTime(year: 1926, month: 10, day: 4, hour: 17, minute: 19, second: 42, millisecond: 594, kind: DateTimeKind.Utc),
    ModelInner = null,
    NullableValue = new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 4, second: 50, millisecond: 216, kind: DateTimeKind.Utc),
},
            new DateTimetimestamp_with_time_zone0M
{
    Id = 161,
    Value = new DateTime(year: 1934, month: 10, day: 11, hour: 6, minute: 55, second: 51, millisecond: 445, kind: DateTimeKind.Utc),
    ModelInner = new DateTimetimestamp_with_time_zone0MI
{
    Id = 61,
    Value = new DateTime(year: 1999, month: 10, day: 4, hour: 17, minute: 35, second: 50, millisecond: 866, kind: DateTimeKind.Utc),
    NullableValue = new DateTime(year: 1981, month: 10, day: 19, hour: 7, minute: 52, second: 45, millisecond: 866, kind: DateTimeKind.Utc),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 4, hour: 8, minute: 12, second: 30, millisecond: 709, kind: DateTimeKind.Utc)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 8, hour: 5, minute: 45, second: 1, millisecond: 901, kind: DateTimeKind.Utc)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1925, month: 10, day: 5, hour: 22, minute: 28, second: 23, millisecond: 775, kind: DateTimeKind.Utc)));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 10, hour: 5, minute: 55, second: 21, millisecond: 431, kind: DateTimeKind.Utc)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 16, hour: 21, minute: 54, second: 4, millisecond: 913, kind: DateTimeKind.Utc)));
                nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 5, hour: 15, minute: 57, second: 54, millisecond: 805, kind: DateTimeKind.Utc)));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[30], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
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
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[1], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[2], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[3], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[4], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[5], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[26],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[27],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[7], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[8], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[9], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[10], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[11], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[12], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[4], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[5], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[6], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[7], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[8], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[9], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[10], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[11], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[12], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[1], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[2], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[3], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[4], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[5], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[6], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[7], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[8], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[9], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[10], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[11], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[12], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[24],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[25],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[26],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[27],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
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
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
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
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[23],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 30, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[29], false);
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
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[29], false);
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
                 ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimetimestamp_with_time_zone0M.AssertModel(secondItems2[20],_testData[30], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelBatchAsync(connection, 101, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[11], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[12], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSTSelectModelBatch(connection, 101, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[7], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[8], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[9], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[10], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[11], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[12], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[13], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[14], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[15], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[16], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[17], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[18], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[19], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[20], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[14],_testData[21], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[15],_testData[22], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[16],_testData[23], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[17],_testData[24], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[18],_testData[25], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[19],_testData[26], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[20],_testData[27], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[21],_testData[28], false);
                        DateTimetimestamp_with_time_zone0M.AssertModel(models[22],_testData[29], false);
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
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[25], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[26], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[27], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[28], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
DateTimetimestamp_with_time_zone0M.AssertModel(models[0],_testData[16], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[1],_testData[17], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[2],_testData[18], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[3],_testData[19], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[4],_testData[20], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[5],_testData[21], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[6],_testData[22], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[7],_testData[23], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[8],_testData[24], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[9],_testData[25], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[10],_testData[26], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[11],_testData[27], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[12],_testData[28], false);DateTimetimestamp_with_time_zone0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 6, hour: 5, minute: 56, second: 57, millisecond: 216, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 8, hour: 19, minute: 49, second: 12, millisecond: 150, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 18, hour: 18, minute: 22, second: 25, millisecond: 93, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 17, hour: 15, minute: 16, second: 31, millisecond: 649, kind: DateTimeKind.Utc))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 15, second: 44, millisecond: 346, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 15, hour: 17, minute: 22, second: 20, millisecond: 258, kind: DateTimeKind.Utc))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 6, hour: 21, minute: 58, second: 24, millisecond: 725, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 4, minute: 53, second: 31, millisecond: 708, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 13, hour: 5, minute: 31, second: 36, millisecond: 91, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 7, hour: 3, minute: 24, second: 3, millisecond: 434, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 4, hour: 8, minute: 12, second: 30, millisecond: 709, kind: DateTimeKind.Utc))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 17, hour: 5, minute: 43, second: 49, millisecond: 3, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 21, minute: 51, second: 48, millisecond: 359, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 10, hour: 17, minute: 8, second: 33, millisecond: 973, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 1, hour: 18, minute: 29, second: 25, millisecond: 982, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 8, hour: 5, minute: 45, second: 1, millisecond: 901, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 3, second: 19, millisecond: 12, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 11, hour: 4, minute: 36, second: 30, millisecond: 445, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 5, hour: 22, minute: 28, second: 23, millisecond: 775, kind: DateTimeKind.Utc))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 2, hour: 12, minute: 36, second: 15, millisecond: 2, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 10, hour: 2, minute: 52, second: 31, millisecond: 534, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 54, second: 51, millisecond: 44, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 10, hour: 5, minute: 55, second: 21, millisecond: 431, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 16, hour: 20, minute: 14, second: 16, millisecond: 222, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 16, hour: 21, minute: 54, second: 4, millisecond: 913, kind: DateTimeKind.Utc))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 16, hour: 11, minute: 19, second: 58, millisecond: 757, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 5, hour: 6, minute: 7, second: 15, millisecond: 45, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 4, hour: 19, minute: 45, second: 38, millisecond: 623, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 5, hour: 15, minute: 57, second: 54, millisecond: 805, kind: DateTimeKind.Utc))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 9, hour: 2, minute: 40, second: 54, millisecond: 558, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 5, hour: 9, minute: 54, second: 53, millisecond: 128, kind: DateTimeKind.Utc))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 16, hour: 1, minute: 13, second: 30, millisecond: 749, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 3, hour: 18, minute: 22, second: 7, millisecond: 414, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 9, hour: 7, minute: 32, second: 57, millisecond: 743, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 1, hour: 11, minute: 26, second: 4, millisecond: 509, kind: DateTimeKind.Utc))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 5, hour: 21, minute: 17, second: 1, millisecond: 840, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 13, hour: 11, minute: 50, second: 23, millisecond: 365, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 13, minute: 51, second: 44, millisecond: 338, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 16, hour: 14, minute: 29, second: 37, millisecond: 477, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 14, hour: 19, minute: 29, second: 22, millisecond: 257, kind: DateTimeKind.Utc))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 16, hour: 8, minute: 42, second: 27, millisecond: 925, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 17, hour: 11, minute: 38, second: 12, millisecond: 322, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 19, hour: 15, minute: 27, second: 19, millisecond: 922, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 17, hour: 17, minute: 51, second: 34, millisecond: 211, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 5, hour: 9, minute: 4, second: 36, millisecond: 267, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 4, second: 20, millisecond: 960, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 14, hour: 8, minute: 12, second: 40, millisecond: 224, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 14, hour: 5, minute: 50, second: 38, millisecond: 879, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 9, hour: 11, minute: 2, second: 15, millisecond: 735, kind: DateTimeKind.Utc))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 1, hour: 4, minute: 29, second: 36, millisecond: 160, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 4, hour: 9, minute: 7, second: 27, millisecond: 100, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 12, hour: 2, minute: 56, second: 9, millisecond: 288, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 11, hour: 18, minute: 48, second: 3, millisecond: 380, kind: DateTimeKind.Utc))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 16, minute: 42, second: 34, millisecond: 335, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 11, hour: 11, minute: 51, second: 57, millisecond: 453, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 11, hour: 12, minute: 50, second: 43, millisecond: 474, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 16, hour: 14, minute: 45, second: 21, millisecond: 34, kind: DateTimeKind.Utc))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 19, minute: 23, second: 49, millisecond: 599, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 7, minute: 19, second: 31, millisecond: 75, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 10, minute: 18, second: 44, millisecond: 302, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 4, hour: 17, minute: 54, second: 2, millisecond: 75, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 1, hour: 11, minute: 47, second: 43, millisecond: 27, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 15, hour: 22, minute: 20, second: 42, millisecond: 313, kind: DateTimeKind.Utc))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 1, hour: 19, minute: 24, second: 5, millisecond: 68, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 16, hour: 5, minute: 55, second: 51, millisecond: 996, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 5, hour: 10, minute: 20, second: 37, millisecond: 510, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 3, hour: 20, minute: 22, second: 44, millisecond: 934, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 4, hour: 21, minute: 23, second: 56, millisecond: 237, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 4, hour: 17, minute: 19, second: 42, millisecond: 594, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 4, second: 50, millisecond: 216, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 11, hour: 6, minute: 55, second: 51, millisecond: 445, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 4, hour: 17, minute: 35, second: 50, millisecond: 866, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 19, hour: 7, minute: 52, second: 45, millisecond: 866, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 6, hour: 5, minute: 56, second: 57, millisecond: 216, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 8, hour: 19, minute: 49, second: 12, millisecond: 150, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 18, hour: 18, minute: 22, second: 25, millisecond: 93, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 17, hour: 15, minute: 16, second: 31, millisecond: 649, kind: DateTimeKind.Utc))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 7, hour: 2, minute: 15, second: 44, millisecond: 346, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 15, hour: 17, minute: 22, second: 20, millisecond: 258, kind: DateTimeKind.Utc))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 6, hour: 21, minute: 58, second: 24, millisecond: 725, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 4, minute: 53, second: 31, millisecond: 708, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 13, hour: 5, minute: 31, second: 36, millisecond: 91, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 7, hour: 3, minute: 24, second: 3, millisecond: 434, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 4, hour: 8, minute: 12, second: 30, millisecond: 709, kind: DateTimeKind.Utc))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 17, hour: 5, minute: 43, second: 49, millisecond: 3, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 21, minute: 51, second: 48, millisecond: 359, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 10, hour: 17, minute: 8, second: 33, millisecond: 973, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 1, hour: 18, minute: 29, second: 25, millisecond: 982, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 8, hour: 5, minute: 45, second: 1, millisecond: 901, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 2, hour: 18, minute: 3, second: 19, millisecond: 12, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 11, hour: 4, minute: 36, second: 30, millisecond: 445, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 5, hour: 22, minute: 28, second: 23, millisecond: 775, kind: DateTimeKind.Utc))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 2, hour: 12, minute: 36, second: 15, millisecond: 2, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 10, hour: 2, minute: 52, second: 31, millisecond: 534, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 12, hour: 17, minute: 54, second: 51, millisecond: 44, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 10, hour: 5, minute: 55, second: 21, millisecond: 431, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 16, hour: 20, minute: 14, second: 16, millisecond: 222, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 16, hour: 21, minute: 54, second: 4, millisecond: 913, kind: DateTimeKind.Utc))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 16, hour: 11, minute: 19, second: 58, millisecond: 757, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 5, hour: 6, minute: 7, second: 15, millisecond: 45, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 4, hour: 19, minute: 45, second: 38, millisecond: 623, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 5, hour: 15, minute: 57, second: 54, millisecond: 805, kind: DateTimeKind.Utc))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 9, hour: 2, minute: 40, second: 54, millisecond: 558, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 5, hour: 9, minute: 54, second: 53, millisecond: 128, kind: DateTimeKind.Utc))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 16, hour: 1, minute: 13, second: 30, millisecond: 749, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 3, hour: 18, minute: 22, second: 7, millisecond: 414, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 9, hour: 7, minute: 32, second: 57, millisecond: 743, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 1, hour: 11, minute: 26, second: 4, millisecond: 509, kind: DateTimeKind.Utc))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 5, hour: 21, minute: 17, second: 1, millisecond: 840, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 13, hour: 11, minute: 50, second: 23, millisecond: 365, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 13, minute: 51, second: 44, millisecond: 338, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 16, hour: 14, minute: 29, second: 37, millisecond: 477, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 14, hour: 19, minute: 29, second: 22, millisecond: 257, kind: DateTimeKind.Utc))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 16, hour: 8, minute: 42, second: 27, millisecond: 925, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 17, hour: 11, minute: 38, second: 12, millisecond: 322, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 19, hour: 15, minute: 27, second: 19, millisecond: 922, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 17, hour: 17, minute: 51, second: 34, millisecond: 211, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 5, hour: 9, minute: 4, second: 36, millisecond: 267, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 4, second: 20, millisecond: 960, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 14, hour: 8, minute: 12, second: 40, millisecond: 224, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 14, hour: 5, minute: 50, second: 38, millisecond: 879, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 9, hour: 11, minute: 2, second: 15, millisecond: 735, kind: DateTimeKind.Utc))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 1, hour: 4, minute: 29, second: 36, millisecond: 160, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 4, hour: 9, minute: 7, second: 27, millisecond: 100, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 12, hour: 2, minute: 56, second: 9, millisecond: 288, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 11, hour: 18, minute: 48, second: 3, millisecond: 380, kind: DateTimeKind.Utc))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 16, minute: 42, second: 34, millisecond: 335, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 11, hour: 11, minute: 51, second: 57, millisecond: 453, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 11, hour: 12, minute: 50, second: 43, millisecond: 474, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 16, hour: 14, minute: 45, second: 21, millisecond: 34, kind: DateTimeKind.Utc))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 19, minute: 23, second: 49, millisecond: 599, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 7, minute: 19, second: 31, millisecond: 75, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 10, minute: 18, second: 44, millisecond: 302, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 4, hour: 17, minute: 54, second: 2, millisecond: 75, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 1, hour: 11, minute: 47, second: 43, millisecond: 27, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 15, hour: 22, minute: 20, second: 42, millisecond: 313, kind: DateTimeKind.Utc))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 1, hour: 19, minute: 24, second: 5, millisecond: 68, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 16, hour: 5, minute: 55, second: 51, millisecond: 996, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 5, hour: 10, minute: 20, second: 37, millisecond: 510, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 3, hour: 20, minute: 22, second: 44, millisecond: 934, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 4, hour: 21, minute: 23, second: 56, millisecond: 237, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 4, hour: 17, minute: 19, second: 42, millisecond: 594, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 13, hour: 17, minute: 4, second: 50, millisecond: 216, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 11, hour: 6, minute: 55, second: 51, millisecond: 445, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 4, hour: 17, minute: 35, second: 50, millisecond: 866, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 19, hour: 7, minute: 52, second: 45, millisecond: 866, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_with_time_zone0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_with_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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


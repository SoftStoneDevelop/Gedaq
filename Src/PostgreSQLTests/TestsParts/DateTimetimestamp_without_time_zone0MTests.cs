

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

        private readonly DateTimetimestamp_without_time_zone0M[] _testData = new DateTimetimestamp_without_time_zone0M[]
        {
            new DateTimetimestamp_without_time_zone0M
{
    Id = 8,
    Value = new DateTime(year: 1992, month: 10, day: 17, hour: 9, minute: 8, second: 33, millisecond: 808, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 13,
    Value = new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 8, second: 45, millisecond: 296, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 8,
    Value = new DateTime(year: 1919, month: 10, day: 1, hour: 5, minute: 39, second: 21, millisecond: 239, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2005, month: 10, day: 11, hour: 7, minute: 3, second: 6, millisecond: 612, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 21,
    Value = new DateTime(year: 1968, month: 10, day: 7, hour: 7, minute: 54, second: 4, millisecond: 723, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1942, month: 10, day: 17, hour: 18, minute: 4, second: 54, millisecond: 3, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 22,
    Value = new DateTime(year: 1950, month: 10, day: 9, hour: 10, minute: 34, second: 3, millisecond: 969, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 9,
    Value = new DateTime(year: 2002, month: 10, day: 8, hour: 22, minute: 54, second: 58, millisecond: 672, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1960, month: 10, day: 18, hour: 16, minute: 13, second: 43, millisecond: 815, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 23,
    Value = new DateTime(year: 1970, month: 10, day: 9, hour: 7, minute: 7, second: 35, millisecond: 800, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1983, month: 10, day: 4, hour: 1, minute: 1, second: 52, millisecond: 765, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 31,
    Value = new DateTime(year: 1984, month: 10, day: 1, hour: 6, minute: 15, second: 38, millisecond: 44, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 12,
    Value = new DateTime(year: 1981, month: 10, day: 10, hour: 8, minute: 51, second: 31, millisecond: 367, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1942, month: 10, day: 5, hour: 12, minute: 28, second: 25, millisecond: 437, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 32,
    Value = new DateTime(year: 1948, month: 10, day: 11, hour: 17, minute: 54, second: 10, millisecond: 618, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2006, month: 10, day: 10, hour: 7, minute: 28, second: 33, millisecond: 517, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 37,
    Value = new DateTime(year: 1951, month: 10, day: 12, hour: 3, minute: 37, second: 40, millisecond: 499, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 16,
    Value = new DateTime(year: 1957, month: 10, day: 12, hour: 13, minute: 24, second: 47, millisecond: 496, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1938, month: 10, day: 7, hour: 9, minute: 33, second: 47, millisecond: 228, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 44,
    Value = new DateTime(year: 1981, month: 10, day: 14, hour: 9, minute: 42, second: 56, millisecond: 674, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 46,
    Value = new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 44, second: 30, millisecond: 666, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 25,
    Value = new DateTime(year: 2001, month: 10, day: 3, hour: 8, minute: 58, second: 17, millisecond: 565, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2017, month: 10, day: 6, hour: 16, minute: 42, second: 55, millisecond: 494, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 48,
    Value = new DateTime(year: 2012, month: 10, day: 8, hour: 13, minute: 20, second: 46, millisecond: 287, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2012, month: 10, day: 6, hour: 5, minute: 26, second: 50, millisecond: 431, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 52,
    Value = new DateTime(year: 1955, month: 10, day: 14, hour: 15, minute: 52, second: 32, millisecond: 80, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 34,
    Value = new DateTime(year: 1921, month: 10, day: 2, hour: 21, minute: 20, second: 43, millisecond: 702, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2008, month: 10, day: 4, hour: 22, minute: 44, second: 4, millisecond: 977, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 54,
    Value = new DateTime(year: 2018, month: 10, day: 18, hour: 11, minute: 11, second: 42, millisecond: 786, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 55,
    Value = new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 52, second: 3, millisecond: 102, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 43,
    Value = new DateTime(year: 1922, month: 10, day: 6, hour: 22, minute: 16, second: 48, millisecond: 841, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2002, month: 10, day: 16, hour: 2, minute: 50, second: 7, millisecond: 330, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1931, month: 10, day: 2, hour: 17, minute: 15, second: 9, millisecond: 720, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 60,
    Value = new DateTime(year: 1939, month: 10, day: 11, hour: 18, minute: 7, second: 35, millisecond: 520, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1986, month: 10, day: 5, hour: 18, minute: 46, second: 20, millisecond: 499, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 68,
    Value = new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 3, second: 29, millisecond: 491, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 48,
    Value = new DateTime(year: 2009, month: 10, day: 17, hour: 3, minute: 48, second: 2, millisecond: 916, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1938, month: 10, day: 14, hour: 4, minute: 16, second: 36, millisecond: 951, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 72,
    Value = new DateTime(year: 1985, month: 10, day: 17, hour: 18, minute: 48, second: 16, millisecond: 993, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 79,
    Value = new DateTime(year: 1931, month: 10, day: 16, hour: 9, minute: 33, second: 11, millisecond: 637, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 49,
    Value = new DateTime(year: 1922, month: 10, day: 9, hour: 16, minute: 54, second: 55, millisecond: 1, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1952, month: 10, day: 8, hour: 19, minute: 1, second: 49, millisecond: 990, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 82,
    Value = new DateTime(year: 2016, month: 10, day: 18, hour: 16, minute: 40, second: 19, millisecond: 793, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 85,
    Value = new DateTime(year: 1977, month: 10, day: 7, hour: 12, minute: 57, second: 25, millisecond: 70, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 55,
    Value = new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 18, second: 57, millisecond: 268, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 94,
    Value = new DateTime(year: 1938, month: 10, day: 16, hour: 1, minute: 53, second: 36, millisecond: 732, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 95,
    Value = new DateTime(year: 1965, month: 10, day: 12, hour: 15, minute: 25, second: 7, millisecond: 332, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 64,
    Value = new DateTime(year: 1972, month: 10, day: 1, hour: 17, minute: 14, second: 11, millisecond: 195, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1920, month: 10, day: 4, hour: 14, minute: 17, second: 46, millisecond: 54, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 98,
    Value = new DateTime(year: 1929, month: 10, day: 8, hour: 6, minute: 27, second: 56, millisecond: 119, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2009, month: 10, day: 19, hour: 17, minute: 13, second: 37, millisecond: 851, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 101,
    Value = new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 57, second: 54, millisecond: 764, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 72,
    Value = new DateTime(year: 1920, month: 10, day: 18, hour: 2, minute: 28, second: 21, millisecond: 350, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1975, month: 10, day: 16, hour: 14, minute: 2, second: 2, millisecond: 901, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 107,
    Value = new DateTime(year: 1965, month: 10, day: 6, hour: 22, minute: 2, second: 15, millisecond: 100, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2011, month: 10, day: 10, hour: 9, minute: 3, second: 41, millisecond: 909, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 115,
    Value = new DateTime(year: 1931, month: 10, day: 5, hour: 3, minute: 52, second: 13, millisecond: 382, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 75,
    Value = new DateTime(year: 1918, month: 10, day: 13, hour: 18, minute: 58, second: 39, millisecond: 693, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1919, month: 10, day: 9, hour: 21, minute: 9, second: 33, millisecond: 920, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1919, month: 10, day: 12, hour: 13, minute: 13, second: 33, millisecond: 873, kind: DateTimeKind.Local),
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 118,
    Value = new DateTime(year: 2013, month: 10, day: 8, hour: 22, minute: 12, second: 36, millisecond: 760, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 124,
    Value = new DateTime(year: 1980, month: 10, day: 19, hour: 11, minute: 50, second: 53, millisecond: 583, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 78,
    Value = new DateTime(year: 1922, month: 10, day: 19, hour: 18, minute: 49, second: 28, millisecond: 817, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 131,
    Value = new DateTime(year: 1932, month: 10, day: 3, hour: 6, minute: 23, second: 44, millisecond: 703, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimetimestamp_without_time_zone0M
{
    Id = 134,
    Value = new DateTime(year: 2004, month: 10, day: 18, hour: 14, minute: 8, second: 55, millisecond: 808, kind: DateTimeKind.Local),
    ModelInner = new DateTimetimestamp_without_time_zone0MI
{
    Id = 81,
    Value = new DateTime(year: 2001, month: 10, day: 6, hour: 3, minute: 38, second: 28, millisecond: 536, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1933, month: 10, day: 15, hour: 18, minute: 26, second: 5, millisecond: 867, kind: DateTimeKind.Local),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0MI)],
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
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
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
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
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
    datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 4, hour: 1, minute: 1, second: 52, millisecond: 765, kind: DateTimeKind.Local)));
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 5, hour: 12, minute: 28, second: 25, millisecond: 437, kind: DateTimeKind.Local)));
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 10, hour: 7, minute: 28, second: 33, millisecond: 517, kind: DateTimeKind.Local)));
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 7, hour: 9, minute: 33, second: 47, millisecond: 228, kind: DateTimeKind.Local)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
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
    datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 6, hour: 5, minute: 26, second: 50, millisecond: 431, kind: DateTimeKind.Local)));
                nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 4, hour: 22, minute: 44, second: 4, millisecond: 977, kind: DateTimeKind.Local)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zone0M> models = null;

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zone0M> models = null;

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimetimestamp_without_time_zone0mi_id
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
                parametrName: "datetimetimestamp_without_time_zone0mi_id", 
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M), typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M), typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M), typeof(FlatDateTimetimestamp_without_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
FROM public.datetimetimestamp_without_time_zone0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zone0m m
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[8], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[9], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[10], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[11], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[12], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[13], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[14], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[15], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[16], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[17], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[18], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[19], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[20], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.datetimetimestamp_without_time_zone0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.datetimetimestamp_without_time_zone0m m
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[9], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[10], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[11], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[12], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[13], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[14], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[15], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[16], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[17], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[18], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[19], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[20], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[3], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[4], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[5], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[6], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[7], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[8], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[9], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[10], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[11], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[12], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[13], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[14], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[21],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[22],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[23],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[24],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[25],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[11], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[12], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[13], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[14], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M), typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                var models2 = new List<FlatDateTimetimestamp_without_time_zone0M>();
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimetimestamp_without_time_zone0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 124, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
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
FROM public.datetimetimestamp_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[14], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[15], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[16], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[17], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[18], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[19], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[20], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[16], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[17], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[18], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[19], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[20], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[21], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[22], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[23], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[24], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[25], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[26], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[27], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[28], false);FlatDateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 32, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[7], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[8], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[9], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[10], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[11], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[12], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[13], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[14], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[21],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimetimestamp_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelBatch(connection, 115, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[29], false);
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
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[10], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[11], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[12], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[13], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[14], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[10], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[11], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[12], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[13], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[14], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[15], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[16], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[17], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[18], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[19], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[20], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[21], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[22], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[23], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[24], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[25], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[26], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[27], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[28], false);DateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[29], false);
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 17, hour: 9, minute: 8, second: 33, millisecond: 808, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 8, second: 45, millisecond: 296, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 1, hour: 5, minute: 39, second: 21, millisecond: 239, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 11, hour: 7, minute: 3, second: 6, millisecond: 612, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 7, hour: 7, minute: 54, second: 4, millisecond: 723, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 17, hour: 18, minute: 4, second: 54, millisecond: 3, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 9, hour: 10, minute: 34, second: 3, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 8, hour: 22, minute: 54, second: 58, millisecond: 672, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 18, hour: 16, minute: 13, second: 43, millisecond: 815, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 9, hour: 7, minute: 7, second: 35, millisecond: 800, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 4, hour: 1, minute: 1, second: 52, millisecond: 765, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 6, minute: 15, second: 38, millisecond: 44, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 10, hour: 8, minute: 51, second: 31, millisecond: 367, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 5, hour: 12, minute: 28, second: 25, millisecond: 437, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 11, hour: 17, minute: 54, second: 10, millisecond: 618, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 10, hour: 7, minute: 28, second: 33, millisecond: 517, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 12, hour: 3, minute: 37, second: 40, millisecond: 499, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 12, hour: 13, minute: 24, second: 47, millisecond: 496, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 7, hour: 9, minute: 33, second: 47, millisecond: 228, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 14, hour: 9, minute: 42, second: 56, millisecond: 674, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 44, second: 30, millisecond: 666, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 3, hour: 8, minute: 58, second: 17, millisecond: 565, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 16, minute: 42, second: 55, millisecond: 494, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 8, hour: 13, minute: 20, second: 46, millisecond: 287, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 6, hour: 5, minute: 26, second: 50, millisecond: 431, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 14, hour: 15, minute: 52, second: 32, millisecond: 80, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 2, hour: 21, minute: 20, second: 43, millisecond: 702, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 4, hour: 22, minute: 44, second: 4, millisecond: 977, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 18, hour: 11, minute: 11, second: 42, millisecond: 786, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 52, second: 3, millisecond: 102, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 6, hour: 22, minute: 16, second: 48, millisecond: 841, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 16, hour: 2, minute: 50, second: 7, millisecond: 330, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 2, hour: 17, minute: 15, second: 9, millisecond: 720, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 11, hour: 18, minute: 7, second: 35, millisecond: 520, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 5, hour: 18, minute: 46, second: 20, millisecond: 499, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 3, second: 29, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 17, hour: 3, minute: 48, second: 2, millisecond: 916, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 14, hour: 4, minute: 16, second: 36, millisecond: 951, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 17, hour: 18, minute: 48, second: 16, millisecond: 993, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 16, hour: 9, minute: 33, second: 11, millisecond: 637, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 9, hour: 16, minute: 54, second: 55, millisecond: 1, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 19, minute: 1, second: 49, millisecond: 990, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 18, hour: 16, minute: 40, second: 19, millisecond: 793, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 7, hour: 12, minute: 57, second: 25, millisecond: 70, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 18, second: 57, millisecond: 268, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 1, minute: 53, second: 36, millisecond: 732, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 15, minute: 25, second: 7, millisecond: 332, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 17, minute: 14, second: 11, millisecond: 195, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 4, hour: 14, minute: 17, second: 46, millisecond: 54, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 8, hour: 6, minute: 27, second: 56, millisecond: 119, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 17, minute: 13, second: 37, millisecond: 851, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 57, second: 54, millisecond: 764, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 18, hour: 2, minute: 28, second: 21, millisecond: 350, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 16, hour: 14, minute: 2, second: 2, millisecond: 901, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 6, hour: 22, minute: 2, second: 15, millisecond: 100, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 10, hour: 9, minute: 3, second: 41, millisecond: 909, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 5, hour: 3, minute: 52, second: 13, millisecond: 382, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 13, hour: 18, minute: 58, second: 39, millisecond: 693, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 9, hour: 21, minute: 9, second: 33, millisecond: 920, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 12, hour: 13, minute: 13, second: 33, millisecond: 873, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 8, hour: 22, minute: 12, second: 36, millisecond: 760, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 19, hour: 11, minute: 50, second: 53, millisecond: 583, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 18, minute: 49, second: 28, millisecond: 817, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 3, hour: 6, minute: 23, second: 44, millisecond: 703, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 18, hour: 14, minute: 8, second: 55, millisecond: 808, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 6, hour: 3, minute: 38, second: 28, millisecond: 536, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 15, hour: 18, minute: 26, second: 5, millisecond: 867, kind: DateTimeKind.Local))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 17, hour: 9, minute: 8, second: 33, millisecond: 808, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 8, second: 45, millisecond: 296, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 1, hour: 5, minute: 39, second: 21, millisecond: 239, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 11, hour: 7, minute: 3, second: 6, millisecond: 612, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 7, hour: 7, minute: 54, second: 4, millisecond: 723, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 17, hour: 18, minute: 4, second: 54, millisecond: 3, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 9, hour: 10, minute: 34, second: 3, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 8, hour: 22, minute: 54, second: 58, millisecond: 672, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 18, hour: 16, minute: 13, second: 43, millisecond: 815, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 9, hour: 7, minute: 7, second: 35, millisecond: 800, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 4, hour: 1, minute: 1, second: 52, millisecond: 765, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 6, minute: 15, second: 38, millisecond: 44, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 10, hour: 8, minute: 51, second: 31, millisecond: 367, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 5, hour: 12, minute: 28, second: 25, millisecond: 437, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 11, hour: 17, minute: 54, second: 10, millisecond: 618, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 10, hour: 7, minute: 28, second: 33, millisecond: 517, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 12, hour: 3, minute: 37, second: 40, millisecond: 499, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 12, hour: 13, minute: 24, second: 47, millisecond: 496, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 7, hour: 9, minute: 33, second: 47, millisecond: 228, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 14, hour: 9, minute: 42, second: 56, millisecond: 674, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 44, second: 30, millisecond: 666, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 3, hour: 8, minute: 58, second: 17, millisecond: 565, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 16, minute: 42, second: 55, millisecond: 494, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 8, hour: 13, minute: 20, second: 46, millisecond: 287, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 6, hour: 5, minute: 26, second: 50, millisecond: 431, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 14, hour: 15, minute: 52, second: 32, millisecond: 80, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 2, hour: 21, minute: 20, second: 43, millisecond: 702, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 4, hour: 22, minute: 44, second: 4, millisecond: 977, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 18, hour: 11, minute: 11, second: 42, millisecond: 786, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 11, hour: 19, minute: 52, second: 3, millisecond: 102, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 6, hour: 22, minute: 16, second: 48, millisecond: 841, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 16, hour: 2, minute: 50, second: 7, millisecond: 330, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 2, hour: 17, minute: 15, second: 9, millisecond: 720, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 11, hour: 18, minute: 7, second: 35, millisecond: 520, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 5, hour: 18, minute: 46, second: 20, millisecond: 499, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 3, second: 29, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 17, hour: 3, minute: 48, second: 2, millisecond: 916, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 14, hour: 4, minute: 16, second: 36, millisecond: 951, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 17, hour: 18, minute: 48, second: 16, millisecond: 993, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 16, hour: 9, minute: 33, second: 11, millisecond: 637, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 9, hour: 16, minute: 54, second: 55, millisecond: 1, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 19, minute: 1, second: 49, millisecond: 990, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 18, hour: 16, minute: 40, second: 19, millisecond: 793, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 7, hour: 12, minute: 57, second: 25, millisecond: 70, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 18, hour: 16, minute: 18, second: 57, millisecond: 268, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 1, minute: 53, second: 36, millisecond: 732, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 15, minute: 25, second: 7, millisecond: 332, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 17, minute: 14, second: 11, millisecond: 195, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 4, hour: 14, minute: 17, second: 46, millisecond: 54, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 8, hour: 6, minute: 27, second: 56, millisecond: 119, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 17, minute: 13, second: 37, millisecond: 851, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 3, minute: 57, second: 54, millisecond: 764, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 18, hour: 2, minute: 28, second: 21, millisecond: 350, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 16, hour: 14, minute: 2, second: 2, millisecond: 901, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 6, hour: 22, minute: 2, second: 15, millisecond: 100, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 10, hour: 9, minute: 3, second: 41, millisecond: 909, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 5, hour: 3, minute: 52, second: 13, millisecond: 382, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 13, hour: 18, minute: 58, second: 39, millisecond: 693, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 9, hour: 21, minute: 9, second: 33, millisecond: 920, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 12, hour: 13, minute: 13, second: 33, millisecond: 873, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 8, hour: 22, minute: 12, second: 36, millisecond: 760, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 19, hour: 11, minute: 50, second: 53, millisecond: 583, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 18, minute: 49, second: 28, millisecond: 817, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 3, hour: 6, minute: 23, second: 44, millisecond: 703, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 18, hour: 14, minute: 8, second: 55, millisecond: 808, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 6, hour: 3, minute: 38, second: 28, millisecond: 536, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 15, hour: 18, minute: 26, second: 5, millisecond: 867, kind: DateTimeKind.Local))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0MI)],
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
FROM public.binary_datetimetimestamp_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zone0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zone0MI.AssertModel(actual, expect, false);
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
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateTimetimestamp_without_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
FROM public.binary_datetimetimestamp_without_time_zone0m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateTimetimestamp_without_time_zone0M>(15);

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
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModel(connection, importCollection);
                var models = ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[14], false);
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
                await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ImportModelAsync(connection, importCollection);
                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DateTimetimestamp_without_time_zone0M.AssertModel(models[0],_testData[0], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[1],_testData[1], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[2],_testData[2], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[3],_testData[3], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[4],_testData[4], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[5],_testData[5], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[6],_testData[6], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[7],_testData[7], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[8],_testData[8], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[9],_testData[9], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[10],_testData[10], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[11],_testData[11], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[12],_testData[12], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[13],_testData[13], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[14],_testData[14], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[15],_testData[15], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[16],_testData[16], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[17],_testData[17], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[18],_testData[18], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[19],_testData[19], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[20],_testData[20], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[21],_testData[21], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[22],_testData[22], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[23],_testData[23], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[24],_testData[24], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[25],_testData[25], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[26],_testData[26], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[27],_testData[27], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[28],_testData[28], false);
                DateTimetimestamp_without_time_zone0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    DateTimetimestamp_without_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    DateTimetimestamp_without_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateTimetimestamp_without_time_zone0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateTimetimestamp_without_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


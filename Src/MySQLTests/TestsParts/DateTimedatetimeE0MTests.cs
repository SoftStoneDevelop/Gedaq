

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDateTimeSingleTypedatetime
    {
    }
    
    internal partial class DateTimeSingleTypedatetime : IDateTimeSingleTypedatetime
    {


#region TestData

        private readonly DateTimedatetimeE0M[] _testData = new DateTimedatetimeE0M[]
        {
            new DateTimedatetimeE0M
{
    Id = 7,
    Value = new DateTime(year: 1984, month: 10, day: 13, hour: 2, minute: 6, second: 13, millisecond: 499, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 12,
    Value = new DateTime(year: 1947, month: 10, day: 9, hour: 22, minute: 58, second: 16, millisecond: 984, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 2,
    Value = new DateTime(year: 1971, month: 10, day: 13, hour: 12, minute: 41, second: 43, millisecond: 774, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1964, month: 10, day: 10, hour: 21, minute: 12, second: 18, millisecond: 310, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 20,
    Value = new DateTime(year: 1966, month: 10, day: 3, hour: 3, minute: 25, second: 43, millisecond: 879, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 28,
    Value = new DateTime(year: 1965, month: 10, day: 12, hour: 13, minute: 48, second: 3, millisecond: 607, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 9,
    Value = new DateTime(year: 1957, month: 10, day: 10, hour: 21, minute: 31, second: 20, millisecond: 951, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2015, month: 10, day: 11, hour: 8, minute: 15, second: 9, millisecond: 489, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 37,
    Value = new DateTime(year: 1989, month: 10, day: 4, hour: 13, minute: 25, second: 2, millisecond: 101, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 46,
    Value = new DateTime(year: 1997, month: 10, day: 5, hour: 13, minute: 28, second: 45, millisecond: 954, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 11,
    Value = new DateTime(year: 1979, month: 10, day: 3, hour: 2, minute: 25, second: 30, millisecond: 347, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 54,
    Value = new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 8, second: 50, millisecond: 618, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1953, month: 10, day: 10, hour: 3, minute: 2, second: 13, millisecond: 793, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 57,
    Value = new DateTime(year: 1940, month: 10, day: 4, hour: 18, minute: 19, second: 51, millisecond: 482, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 15,
    Value = new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 28, second: 6, millisecond: 894, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2019, month: 10, day: 14, hour: 12, minute: 25, second: 39, millisecond: 511, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 62,
    Value = new DateTime(year: 1987, month: 10, day: 2, hour: 2, minute: 5, second: 44, millisecond: 973, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1922, month: 10, day: 19, hour: 10, minute: 2, second: 50, millisecond: 646, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 65,
    Value = new DateTime(year: 1984, month: 10, day: 7, hour: 22, minute: 32, second: 7, millisecond: 851, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 24,
    Value = new DateTime(year: 1992, month: 10, day: 2, hour: 4, minute: 42, second: 7, millisecond: 313, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1958, month: 10, day: 14, hour: 10, minute: 8, second: 53, millisecond: 562, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 69,
    Value = new DateTime(year: 1936, month: 10, day: 6, hour: 12, minute: 58, second: 30, millisecond: 476, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 54, second: 11, millisecond: 947, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 75,
    Value = new DateTime(year: 1982, month: 10, day: 17, hour: 4, minute: 53, second: 12, millisecond: 751, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 30,
    Value = new DateTime(year: 1940, month: 10, day: 4, hour: 15, minute: 35, second: 17, millisecond: 458, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1962, month: 10, day: 4, hour: 6, minute: 18, second: 34, millisecond: 205, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1986, month: 10, day: 15, hour: 9, minute: 53, second: 49, millisecond: 806, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 77,
    Value = new DateTime(year: 2010, month: 10, day: 9, hour: 7, minute: 5, second: 17, millisecond: 871, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 85,
    Value = new DateTime(year: 1982, month: 10, day: 9, hour: 6, minute: 40, second: 4, millisecond: 135, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 33,
    Value = new DateTime(year: 2011, month: 10, day: 8, hour: 1, minute: 9, second: 10, millisecond: 623, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 93,
    Value = new DateTime(year: 2002, month: 10, day: 4, hour: 11, minute: 27, second: 46, millisecond: 223, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 95,
    Value = new DateTime(year: 1993, month: 10, day: 3, hour: 12, minute: 26, second: 2, millisecond: 516, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 41,
    Value = new DateTime(year: 1939, month: 10, day: 14, hour: 14, minute: 39, second: 3, millisecond: 66, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1986, month: 10, day: 14, hour: 9, minute: 10, second: 48, millisecond: 686, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1950, month: 10, day: 5, hour: 11, minute: 13, second: 13, millisecond: 9, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 99,
    Value = new DateTime(year: 1966, month: 10, day: 13, hour: 9, minute: 35, second: 54, millisecond: 385, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1955, month: 10, day: 10, hour: 11, minute: 33, second: 48, millisecond: 532, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 100,
    Value = new DateTime(year: 1920, month: 10, day: 18, hour: 9, minute: 55, second: 24, millisecond: 878, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 48,
    Value = new DateTime(year: 1920, month: 10, day: 19, hour: 19, minute: 52, second: 47, millisecond: 599, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 107,
    Value = new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 32, second: 5, millisecond: 122, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2001, month: 10, day: 2, hour: 21, minute: 16, second: 28, millisecond: 439, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 113,
    Value = new DateTime(year: 1968, month: 10, day: 7, hour: 12, minute: 58, second: 49, millisecond: 671, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 51,
    Value = new DateTime(year: 1943, month: 10, day: 9, hour: 15, minute: 18, second: 42, millisecond: 272, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1982, month: 10, day: 17, hour: 19, minute: 11, second: 33, millisecond: 375, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 120,
    Value = new DateTime(year: 1931, month: 10, day: 2, hour: 8, minute: 8, second: 57, millisecond: 612, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 128,
    Value = new DateTime(year: 1948, month: 10, day: 9, hour: 13, minute: 2, second: 12, millisecond: 625, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 57,
    Value = new DateTime(year: 1919, month: 10, day: 5, hour: 4, minute: 38, second: 44, millisecond: 1, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1970, month: 10, day: 14, hour: 6, minute: 5, second: 56, millisecond: 4, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 137,
    Value = new DateTime(year: 1972, month: 10, day: 5, hour: 17, minute: 44, second: 8, millisecond: 589, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 144,
    Value = new DateTime(year: 2015, month: 10, day: 9, hour: 6, minute: 56, second: 8, millisecond: 643, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 59,
    Value = new DateTime(year: 1943, month: 10, day: 15, hour: 17, minute: 26, second: 31, millisecond: 860, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2019, month: 10, day: 3, hour: 15, minute: 1, second: 52, millisecond: 544, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 149,
    Value = new DateTime(year: 2009, month: 10, day: 12, hour: 13, minute: 12, second: 2, millisecond: 496, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 151,
    Value = new DateTime(year: 1921, month: 10, day: 7, hour: 21, minute: 55, second: 45, millisecond: 872, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 64,
    Value = new DateTime(year: 2004, month: 10, day: 7, hour: 7, minute: 13, second: 4, millisecond: 53, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1999, month: 10, day: 1, hour: 9, minute: 9, second: 12, millisecond: 45, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 157,
    Value = new DateTime(year: 1966, month: 10, day: 18, hour: 7, minute: 3, second: 48, millisecond: 709, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 162,
    Value = new DateTime(year: 1970, month: 10, day: 4, hour: 7, minute: 27, second: 53, millisecond: 969, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 65,
    Value = new DateTime(year: 1994, month: 10, day: 4, hour: 7, minute: 58, second: 57, millisecond: 145, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1932, month: 10, day: 10, hour: 6, minute: 9, second: 32, millisecond: 217, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 170,
    Value = new DateTime(year: 2001, month: 10, day: 6, hour: 5, minute: 55, second: 54, millisecond: 199, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 171,
    Value = new DateTime(year: 1927, month: 10, day: 7, hour: 16, minute: 6, second: 21, millisecond: 604, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 67,
    Value = new DateTime(year: 1994, month: 10, day: 15, hour: 14, minute: 25, second: 26, millisecond: 432, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1951, month: 10, day: 14, hour: 17, minute: 11, second: 22, millisecond: 460, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1993, month: 10, day: 7, hour: 2, minute: 20, second: 57, millisecond: 447, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 180,
    Value = new DateTime(year: 1980, month: 10, day: 12, hour: 12, minute: 16, second: 6, millisecond: 134, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1997, month: 10, day: 16, hour: 4, minute: 37, second: 6, millisecond: 187, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 183,
    Value = new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 48, millisecond: 350, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 74,
    Value = new DateTime(year: 1938, month: 10, day: 16, hour: 19, minute: 41, second: 16, millisecond: 507, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1958, month: 10, day: 2, hour: 10, minute: 20, second: 32, millisecond: 524, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 188,
    Value = new DateTime(year: 1939, month: 10, day: 16, hour: 7, minute: 34, second: 16, millisecond: 82, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 189,
    Value = new DateTime(year: 1987, month: 10, day: 1, hour: 19, minute: 43, second: 12, millisecond: 776, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 78,
    Value = new DateTime(year: 1991, month: 10, day: 13, hour: 14, minute: 52, second: 24, millisecond: 835, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 195,
    Value = new DateTime(year: 2007, month: 10, day: 11, hour: 19, minute: 34, second: 7, millisecond: 71, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1991, month: 10, day: 6, hour: 14, minute: 15, second: 44, millisecond: 194, kind: DateTimeKind.Local),
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetimee0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(12)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(12))]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetimee0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)), 
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetimee0m(
	id,
    value,
    nullablevalue,
    datetimedatetimee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetimee0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(12)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(12),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetimee0mi_id", 
                methodParametrName: "datetimedatetimee0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true)]
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetimee0m(
	id,
    value,
    nullablevalue,
    datetimedatetimee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetimee0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
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
                parametrName: "datetimedatetimee0mi_id", 
                methodParametrName: "datetimedatetimee0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M), typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                await((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                ((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.datetimedatetimee0m m
LEFT JOIN gedaqtests.datetimedatetimee0mi mi ON mi.id = m.datetimedatetimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M), typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                await((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                ((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.datetimedatetimee0m m
LEFT JOIN gedaqtests.datetimedatetimee0mi mi ON mi.id = m.datetimedatetimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateTimeSingleTypedatetime)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeSingleTypedatetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M), typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                await((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
LEFT JOIN gedaqtests.datetimedatetimee0mi mi ON mi.id = m.datetimedatetimee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
                var models = await((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[1], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[2], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[3], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[4], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[5], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[6], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[7], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[8], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[9], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[10], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[11], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[12], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[13], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[14], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[20],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[21],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[22],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[23],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[24],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[25],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[26],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[27],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[28],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[29],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[30],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[31],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[32],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[4], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[5], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[6], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[7], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[8], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[9], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[10], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[11], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[12], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[13], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[14], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[20],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[21],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[22],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[23],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[24],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[25],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[26],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[27],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[28],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[29],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M), typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                await((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 180, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetimeE0M>();
                var models2 = new List<FlatDateTimedatetimeE0M>();
                ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 171, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var firstItems2 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 12, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 180, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[22],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[23],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[24],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[25],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[26],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[27],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[28],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[29],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 170, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[24],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
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
FROM gedaqtests.datetimedatetimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems1 = new List<FlatDateTimedatetimeE0M>();
                var secondItems2 = new List<FlatDateTimedatetimeE0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatch(connection, 95, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
LEFT JOIN gedaqtests.datetimedatetimee0mi mi ON mi.id = m.datetimedatetimee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimedatetimeE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)),
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
                var models = await((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[2], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[3], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[4], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[5], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[6], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[7], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[8], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[9], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[10], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[11], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[12], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[13], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[14], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[20],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[21],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[22],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[23],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[24],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[25],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[26],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[27],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[28],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[29],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[30],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[31],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetimeE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatch(connection, 128, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models = await ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                DateTimedatetimeE0M.AssertModel(models[0],_testData[27], false);
                DateTimedatetimeE0M.AssertModel(models[1],_testData[28], false);
                DateTimedatetimeE0M.AssertModel(models[2],_testData[29], false);
                DateTimedatetimeE0M.AssertModel(models[3],_testData[30], false);
                DateTimedatetimeE0M.AssertModel(models[4],_testData[31], false);
                DateTimedatetimeE0M.AssertModel(models[5],_testData[32], false);
                DateTimedatetimeE0M.AssertModel(models[6],_testData[33], false);
                DateTimedatetimeE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                DateTimedatetimeE0M.AssertModel(models[0],_testData[21], false);
                DateTimedatetimeE0M.AssertModel(models[1],_testData[22], false);
                DateTimedatetimeE0M.AssertModel(models[2],_testData[23], false);
                DateTimedatetimeE0M.AssertModel(models[3],_testData[24], false);
                DateTimedatetimeE0M.AssertModel(models[4],_testData[25], false);
                DateTimedatetimeE0M.AssertModel(models[5],_testData[26], false);
                DateTimedatetimeE0M.AssertModel(models[6],_testData[27], false);
                DateTimedatetimeE0M.AssertModel(models[7],_testData[28], false);
                DateTimedatetimeE0M.AssertModel(models[8],_testData[29], false);
                DateTimedatetimeE0M.AssertModel(models[9],_testData[30], false);
                DateTimedatetimeE0M.AssertModel(models[10],_testData[31], false);
                DateTimedatetimeE0M.AssertModel(models[11],_testData[32], false);
                DateTimedatetimeE0M.AssertModel(models[12],_testData[33], false);
                DateTimedatetimeE0M.AssertModel(models[13],_testData[34], false);
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
FROM gedaqtests.datetimedatetimee0m m
LEFT JOIN gedaqtests.datetimedatetimee0mi mi ON mi.id = m.datetimedatetimee0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 13, hour: 2, minute: 6, second: 13, millisecond: 499, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 22, minute: 58, second: 16, millisecond: 984, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 13, hour: 12, minute: 41, second: 43, millisecond: 774, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 10, hour: 21, minute: 12, second: 18, millisecond: 310, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 3, hour: 3, minute: 25, second: 43, millisecond: 879, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 13, minute: 48, second: 3, millisecond: 607, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 10, hour: 21, minute: 31, second: 20, millisecond: 951, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 11, hour: 8, minute: 15, second: 9, millisecond: 489, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 4, hour: 13, minute: 25, second: 2, millisecond: 101, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 5, hour: 13, minute: 28, second: 45, millisecond: 954, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 3, hour: 2, minute: 25, second: 30, millisecond: 347, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 8, second: 50, millisecond: 618, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 10, hour: 3, minute: 2, second: 13, millisecond: 793, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 18, minute: 19, second: 51, millisecond: 482, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 28, second: 6, millisecond: 894, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 14, hour: 12, minute: 25, second: 39, millisecond: 511, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 2, hour: 2, minute: 5, second: 44, millisecond: 973, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 10, minute: 2, second: 50, millisecond: 646, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 7, hour: 22, minute: 32, second: 7, millisecond: 851, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 2, hour: 4, minute: 42, second: 7, millisecond: 313, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 14, hour: 10, minute: 8, second: 53, millisecond: 562, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 12, minute: 58, second: 30, millisecond: 476, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 54, second: 11, millisecond: 947, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 4, minute: 53, second: 12, millisecond: 751, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 15, minute: 35, second: 17, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 4, hour: 6, minute: 18, second: 34, millisecond: 205, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 15, hour: 9, minute: 53, second: 49, millisecond: 806, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 9, hour: 7, minute: 5, second: 17, millisecond: 871, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 9, hour: 6, minute: 40, second: 4, millisecond: 135, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 8, hour: 1, minute: 9, second: 10, millisecond: 623, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 4, hour: 11, minute: 27, second: 46, millisecond: 223, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 3, hour: 12, minute: 26, second: 2, millisecond: 516, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 14, hour: 14, minute: 39, second: 3, millisecond: 66, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 14, hour: 9, minute: 10, second: 48, millisecond: 686, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 5, hour: 11, minute: 13, second: 13, millisecond: 9, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 13, hour: 9, minute: 35, second: 54, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 11, minute: 33, second: 48, millisecond: 532, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 18, hour: 9, minute: 55, second: 24, millisecond: 878, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 19, hour: 19, minute: 52, second: 47, millisecond: 599, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 32, second: 5, millisecond: 122, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 21, minute: 16, second: 28, millisecond: 439, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 7, hour: 12, minute: 58, second: 49, millisecond: 671, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 9, hour: 15, minute: 18, second: 42, millisecond: 272, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 19, minute: 11, second: 33, millisecond: 375, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 2, hour: 8, minute: 8, second: 57, millisecond: 612, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 9, hour: 13, minute: 2, second: 12, millisecond: 625, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 5, hour: 4, minute: 38, second: 44, millisecond: 1, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 14, hour: 6, minute: 5, second: 56, millisecond: 4, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 5, hour: 17, minute: 44, second: 8, millisecond: 589, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 9, hour: 6, minute: 56, second: 8, millisecond: 643, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 15, hour: 17, minute: 26, second: 31, millisecond: 860, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 3, hour: 15, minute: 1, second: 52, millisecond: 544, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 12, hour: 13, minute: 12, second: 2, millisecond: 496, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 7, hour: 21, minute: 55, second: 45, millisecond: 872, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 7, hour: 7, minute: 13, second: 4, millisecond: 53, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 1, hour: 9, minute: 9, second: 12, millisecond: 45, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 18, hour: 7, minute: 3, second: 48, millisecond: 709, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 4, hour: 7, minute: 27, second: 53, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 4, hour: 7, minute: 58, second: 57, millisecond: 145, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 10, hour: 6, minute: 9, second: 32, millisecond: 217, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 6, hour: 5, minute: 55, second: 54, millisecond: 199, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 16, minute: 6, second: 21, millisecond: 604, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 15, hour: 14, minute: 25, second: 26, millisecond: 432, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 14, hour: 17, minute: 11, second: 22, millisecond: 460, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 7, hour: 2, minute: 20, second: 57, millisecond: 447, kind: DateTimeKind.Local))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 12, hour: 12, minute: 16, second: 6, millisecond: 134, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 16, hour: 4, minute: 37, second: 6, millisecond: 187, kind: DateTimeKind.Local))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 48, millisecond: 350, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 19, minute: 41, second: 16, millisecond: 507, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 2, hour: 10, minute: 20, second: 32, millisecond: 524, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 16, hour: 7, minute: 34, second: 16, millisecond: 82, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 1, hour: 19, minute: 43, second: 12, millisecond: 776, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 13, hour: 14, minute: 52, second: 24, millisecond: 835, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 11, hour: 19, minute: 34, second: 7, millisecond: 71, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 6, hour: 14, minute: 15, second: 44, millisecond: 194, kind: DateTimeKind.Local))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 13, hour: 2, minute: 6, second: 13, millisecond: 499, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 22, minute: 58, second: 16, millisecond: 984, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 13, hour: 12, minute: 41, second: 43, millisecond: 774, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 10, hour: 21, minute: 12, second: 18, millisecond: 310, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 3, hour: 3, minute: 25, second: 43, millisecond: 879, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 13, minute: 48, second: 3, millisecond: 607, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 10, hour: 21, minute: 31, second: 20, millisecond: 951, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 11, hour: 8, minute: 15, second: 9, millisecond: 489, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 4, hour: 13, minute: 25, second: 2, millisecond: 101, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 5, hour: 13, minute: 28, second: 45, millisecond: 954, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 3, hour: 2, minute: 25, second: 30, millisecond: 347, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 2, hour: 19, minute: 8, second: 50, millisecond: 618, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 10, hour: 3, minute: 2, second: 13, millisecond: 793, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 18, minute: 19, second: 51, millisecond: 482, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 28, second: 6, millisecond: 894, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 14, hour: 12, minute: 25, second: 39, millisecond: 511, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 2, hour: 2, minute: 5, second: 44, millisecond: 973, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 10, minute: 2, second: 50, millisecond: 646, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 7, hour: 22, minute: 32, second: 7, millisecond: 851, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 2, hour: 4, minute: 42, second: 7, millisecond: 313, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 14, hour: 10, minute: 8, second: 53, millisecond: 562, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 12, minute: 58, second: 30, millisecond: 476, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 8, minute: 54, second: 11, millisecond: 947, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 4, minute: 53, second: 12, millisecond: 751, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 15, minute: 35, second: 17, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 4, hour: 6, minute: 18, second: 34, millisecond: 205, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 15, hour: 9, minute: 53, second: 49, millisecond: 806, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 9, hour: 7, minute: 5, second: 17, millisecond: 871, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 9, hour: 6, minute: 40, second: 4, millisecond: 135, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 8, hour: 1, minute: 9, second: 10, millisecond: 623, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 4, hour: 11, minute: 27, second: 46, millisecond: 223, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 3, hour: 12, minute: 26, second: 2, millisecond: 516, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 14, hour: 14, minute: 39, second: 3, millisecond: 66, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 14, hour: 9, minute: 10, second: 48, millisecond: 686, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 5, hour: 11, minute: 13, second: 13, millisecond: 9, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 13, hour: 9, minute: 35, second: 54, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 11, minute: 33, second: 48, millisecond: 532, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 18, hour: 9, minute: 55, second: 24, millisecond: 878, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 19, hour: 19, minute: 52, second: 47, millisecond: 599, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 4, hour: 2, minute: 32, second: 5, millisecond: 122, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 21, minute: 16, second: 28, millisecond: 439, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 7, hour: 12, minute: 58, second: 49, millisecond: 671, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 9, hour: 15, minute: 18, second: 42, millisecond: 272, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 17, hour: 19, minute: 11, second: 33, millisecond: 375, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 2, hour: 8, minute: 8, second: 57, millisecond: 612, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 9, hour: 13, minute: 2, second: 12, millisecond: 625, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 5, hour: 4, minute: 38, second: 44, millisecond: 1, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 14, hour: 6, minute: 5, second: 56, millisecond: 4, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 5, hour: 17, minute: 44, second: 8, millisecond: 589, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 9, hour: 6, minute: 56, second: 8, millisecond: 643, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 15, hour: 17, minute: 26, second: 31, millisecond: 860, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 3, hour: 15, minute: 1, second: 52, millisecond: 544, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 12, hour: 13, minute: 12, second: 2, millisecond: 496, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 7, hour: 21, minute: 55, second: 45, millisecond: 872, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 7, hour: 7, minute: 13, second: 4, millisecond: 53, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 1, hour: 9, minute: 9, second: 12, millisecond: 45, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 18, hour: 7, minute: 3, second: 48, millisecond: 709, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 4, hour: 7, minute: 27, second: 53, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 4, hour: 7, minute: 58, second: 57, millisecond: 145, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 10, hour: 6, minute: 9, second: 32, millisecond: 217, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 6, hour: 5, minute: 55, second: 54, millisecond: 199, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 16, minute: 6, second: 21, millisecond: 604, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 15, hour: 14, minute: 25, second: 26, millisecond: 432, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 14, hour: 17, minute: 11, second: 22, millisecond: 460, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 7, hour: 2, minute: 20, second: 57, millisecond: 447, kind: DateTimeKind.Local))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 12, hour: 12, minute: 16, second: 6, millisecond: 134, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 16, hour: 4, minute: 37, second: 6, millisecond: 187, kind: DateTimeKind.Local))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 48, millisecond: 350, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 19, minute: 41, second: 16, millisecond: 507, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 2, hour: 10, minute: 20, second: 32, millisecond: 524, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 16, hour: 7, minute: 34, second: 16, millisecond: 82, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 1, hour: 19, minute: 43, second: 12, millisecond: 776, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 13, hour: 14, minute: 52, second: 24, millisecond: 835, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 11, hour: 19, minute: 34, second: 7, millisecond: 71, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 6, hour: 14, minute: 15, second: 44, millisecond: 194, kind: DateTimeKind.Local))));

            }
        }

#endregion

    }
}


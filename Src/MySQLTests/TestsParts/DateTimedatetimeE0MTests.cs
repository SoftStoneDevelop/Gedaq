

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
    Id = 1,
    Value = new DateTime(year: 2016, month: 10, day: 12, hour: 3, minute: 46, second: 54, millisecond: 902, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1925, month: 10, day: 6, hour: 19, minute: 30, second: 45, millisecond: 677, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 3,
    Value = new DateTime(year: 1984, month: 10, day: 8, hour: 5, minute: 37, second: 34, millisecond: 200, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 8,
    Value = new DateTime(year: 2012, month: 10, day: 13, hour: 19, minute: 50, second: 44, millisecond: 518, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1990, month: 10, day: 8, hour: 15, minute: 52, second: 35, millisecond: 298, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 7,
    Value = new DateTime(year: 2000, month: 10, day: 5, hour: 20, minute: 48, second: 11, millisecond: 884, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 14,
    Value = new DateTime(year: 2001, month: 10, day: 8, hour: 14, minute: 19, second: 32, millisecond: 263, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 10,
    Value = new DateTime(year: 1970, month: 10, day: 10, hour: 22, minute: 47, second: 30, millisecond: 152, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 15,
    Value = new DateTime(year: 1996, month: 10, day: 9, hour: 3, minute: 50, second: 54, millisecond: 264, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 20,
    Value = new DateTime(year: 1972, month: 10, day: 18, hour: 21, minute: 46, second: 19, millisecond: 219, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 17,
    Value = new DateTime(year: 2014, month: 10, day: 9, hour: 15, minute: 22, second: 22, millisecond: 235, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 8, second: 55, millisecond: 341, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1939, month: 10, day: 2, hour: 19, minute: 24, second: 23, millisecond: 130, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 28,
    Value = new DateTime(year: 1923, month: 10, day: 12, hour: 12, minute: 39, second: 38, millisecond: 410, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 36,
    Value = new DateTime(year: 1930, month: 10, day: 8, hour: 2, minute: 13, second: 26, millisecond: 106, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 26,
    Value = new DateTime(year: 1926, month: 10, day: 8, hour: 4, minute: 42, second: 56, millisecond: 835, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2018, month: 10, day: 15, hour: 15, minute: 43, second: 20, millisecond: 688, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 37,
    Value = new DateTime(year: 1997, month: 10, day: 12, hour: 12, minute: 26, second: 23, millisecond: 518, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1951, month: 10, day: 9, hour: 3, minute: 14, second: 50, millisecond: 285, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 45,
    Value = new DateTime(year: 1951, month: 10, day: 3, hour: 20, minute: 53, second: 19, millisecond: 636, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 34,
    Value = new DateTime(year: 1949, month: 10, day: 8, hour: 3, minute: 31, second: 51, millisecond: 27, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1926, month: 10, day: 19, hour: 14, minute: 32, second: 26, millisecond: 191, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 51,
    Value = new DateTime(year: 1943, month: 10, day: 4, hour: 1, minute: 13, second: 18, millisecond: 515, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 52,
    Value = new DateTime(year: 1938, month: 10, day: 12, hour: 12, minute: 1, second: 29, millisecond: 274, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 43,
    Value = new DateTime(year: 1954, month: 10, day: 18, hour: 3, minute: 48, second: 29, millisecond: 440, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 57,
    Value = new DateTime(year: 2019, month: 10, day: 18, hour: 19, minute: 31, second: 55, millisecond: 788, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2010, month: 10, day: 18, hour: 10, minute: 54, second: 28, millisecond: 578, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 59,
    Value = new DateTime(year: 2002, month: 10, day: 19, hour: 3, minute: 5, second: 7, millisecond: 203, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 50,
    Value = new DateTime(year: 1979, month: 10, day: 18, hour: 20, minute: 53, second: 32, millisecond: 416, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1928, month: 10, day: 8, hour: 9, minute: 54, second: 40, millisecond: 665, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 62,
    Value = new DateTime(year: 2013, month: 10, day: 18, hour: 8, minute: 16, second: 33, millisecond: 661, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 68,
    Value = new DateTime(year: 2017, month: 10, day: 8, hour: 20, minute: 23, second: 44, millisecond: 373, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 54,
    Value = new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 28, second: 52, millisecond: 612, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1977, month: 10, day: 5, hour: 6, minute: 27, second: 21, millisecond: 687, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 2009, month: 10, day: 5, hour: 4, minute: 11, second: 13, millisecond: 319, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 69,
    Value = new DateTime(year: 1937, month: 10, day: 4, hour: 1, minute: 47, second: 10, millisecond: 658, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 77,
    Value = new DateTime(year: 1981, month: 10, day: 17, hour: 16, minute: 40, second: 53, millisecond: 643, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 60,
    Value = new DateTime(year: 1935, month: 10, day: 12, hour: 6, minute: 1, second: 27, millisecond: 493, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2011, month: 10, day: 6, hour: 10, minute: 9, second: 10, millisecond: 245, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 81,
    Value = new DateTime(year: 1937, month: 10, day: 6, hour: 13, minute: 17, second: 24, millisecond: 238, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 82,
    Value = new DateTime(year: 2001, month: 10, day: 12, hour: 11, minute: 54, second: 17, millisecond: 912, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 62,
    Value = new DateTime(year: 1938, month: 10, day: 4, hour: 10, minute: 34, second: 23, millisecond: 400, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1975, month: 10, day: 1, hour: 20, minute: 25, second: 48, millisecond: 630, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 85,
    Value = new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 49, second: 55, millisecond: 707, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 87,
    Value = new DateTime(year: 2009, month: 10, day: 9, hour: 6, minute: 18, second: 41, millisecond: 116, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 69,
    Value = new DateTime(year: 2018, month: 10, day: 11, hour: 6, minute: 17, second: 52, millisecond: 777, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1987, month: 10, day: 19, hour: 6, minute: 22, second: 57, millisecond: 189, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 92,
    Value = new DateTime(year: 1943, month: 10, day: 3, hour: 1, minute: 9, second: 53, millisecond: 556, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1949, month: 10, day: 15, hour: 3, minute: 46, second: 49, millisecond: 802, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 100,
    Value = new DateTime(year: 2003, month: 10, day: 5, hour: 12, minute: 29, second: 50, millisecond: 263, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 75,
    Value = new DateTime(year: 1940, month: 10, day: 14, hour: 18, minute: 47, second: 49, millisecond: 237, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 103,
    Value = new DateTime(year: 1947, month: 10, day: 9, hour: 1, minute: 56, second: 58, millisecond: 73, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1926, month: 10, day: 13, hour: 4, minute: 34, second: 41, millisecond: 133, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 108,
    Value = new DateTime(year: 1964, month: 10, day: 16, hour: 21, minute: 7, second: 32, millisecond: 463, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 83,
    Value = new DateTime(year: 2010, month: 10, day: 18, hour: 16, minute: 53, second: 22, millisecond: 971, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2013, month: 10, day: 13, hour: 17, minute: 53, second: 30, millisecond: 529, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 117,
    Value = new DateTime(year: 2003, month: 10, day: 3, hour: 3, minute: 35, second: 39, millisecond: 207, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1994, month: 10, day: 11, hour: 22, minute: 13, second: 8, millisecond: 343, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 122,
    Value = new DateTime(year: 2004, month: 10, day: 8, hour: 21, minute: 20, second: 21, millisecond: 50, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 88,
    Value = new DateTime(year: 2012, month: 10, day: 9, hour: 11, minute: 28, second: 46, millisecond: 158, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1957, month: 10, day: 9, hour: 22, minute: 45, second: 28, millisecond: 528, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 126,
    Value = new DateTime(year: 1937, month: 10, day: 16, hour: 5, minute: 55, second: 4, millisecond: 966, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 134,
    Value = new DateTime(year: 1938, month: 10, day: 10, hour: 6, minute: 36, second: 1, millisecond: 587, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 89,
    Value = new DateTime(year: 1987, month: 10, day: 19, hour: 7, minute: 5, second: 8, millisecond: 876, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1963, month: 10, day: 14, hour: 22, minute: 14, second: 17, millisecond: 917, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 141,
    Value = new DateTime(year: 1926, month: 10, day: 6, hour: 10, minute: 39, second: 56, millisecond: 502, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 143,
    Value = new DateTime(year: 2012, month: 10, day: 12, hour: 22, minute: 51, second: 20, millisecond: 990, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 91,
    Value = new DateTime(year: 1937, month: 10, day: 4, hour: 16, minute: 35, second: 50, millisecond: 919, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetimeE0M
{
    Id = 145,
    Value = new DateTime(year: 1922, month: 10, day: 13, hour: 4, minute: 53, second: 57, millisecond: 514, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1917, month: 10, day: 5, hour: 20, minute: 14, second: 40, millisecond: 95, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 149,
    Value = new DateTime(year: 1934, month: 10, day: 12, hour: 16, minute: 54, second: 16, millisecond: 992, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetimeE0MI
{
    Id = 95,
    Value = new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 31, second: 25, millisecond: 476, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2006, month: 10, day: 19, hour: 12, minute: 55, second: 8, millisecond: 918, kind: DateTimeKind.Local),
},
            new DateTimedatetimeE0M
{
    Id = 151,
    Value = new DateTime(year: 1918, month: 10, day: 9, hour: 8, minute: 58, second: 51, millisecond: 433, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[22],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[23],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[24],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[25],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[26],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[27],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[28],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[29],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[30],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[31],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[7], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[8], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[9], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[10], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[11], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[12], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[13], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[14], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[20],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[21],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[22],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[23],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[24],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[25],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[26],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[27],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 1, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[33],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 141, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(firstItems2[16],_testData[34], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 143, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 100, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDateTimedatetimeE0M.AssertModel(models[0],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[1],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(models[2],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDateTimedatetimeE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatch(connection, 14, 36))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateTimedatetimeE0M.AssertModel(models[0],_testData[8], false);
                        DateTimedatetimeE0M.AssertModel(models[1],_testData[9], false);
                        DateTimedatetimeE0M.AssertModel(models[2],_testData[10], false);
                        DateTimedatetimeE0M.AssertModel(models[3],_testData[11], false);
                        DateTimedatetimeE0M.AssertModel(models[4],_testData[12], false);
                        DateTimedatetimeE0M.AssertModel(models[5],_testData[13], false);
                        DateTimedatetimeE0M.AssertModel(models[6],_testData[14], false);
                        DateTimedatetimeE0M.AssertModel(models[7],_testData[15], false);
                        DateTimedatetimeE0M.AssertModel(models[8],_testData[16], false);
                        DateTimedatetimeE0M.AssertModel(models[9],_testData[17], false);
                        DateTimedatetimeE0M.AssertModel(models[10],_testData[18], false);
                        DateTimedatetimeE0M.AssertModel(models[11],_testData[19], false);
                        DateTimedatetimeE0M.AssertModel(models[12],_testData[20], false);
                        DateTimedatetimeE0M.AssertModel(models[13],_testData[21], false);
                        DateTimedatetimeE0M.AssertModel(models[14],_testData[22], false);
                        DateTimedatetimeE0M.AssertModel(models[15],_testData[23], false);
                        DateTimedatetimeE0M.AssertModel(models[16],_testData[24], false);
                        DateTimedatetimeE0M.AssertModel(models[17],_testData[25], false);
                        DateTimedatetimeE0M.AssertModel(models[18],_testData[26], false);
                        DateTimedatetimeE0M.AssertModel(models[19],_testData[27], false);
                        DateTimedatetimeE0M.AssertModel(models[20],_testData[28], false);
                        DateTimedatetimeE0M.AssertModel(models[21],_testData[29], false);
                        DateTimedatetimeE0M.AssertModel(models[22],_testData[30], false);
                        DateTimedatetimeE0M.AssertModel(models[23],_testData[31], false);
                        DateTimedatetimeE0M.AssertModel(models[24],_testData[32], false);
                        DateTimedatetimeE0M.AssertModel(models[25],_testData[33], false);
                        DateTimedatetimeE0M.AssertModel(models[26],_testData[34], false);
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
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                DateTimedatetimeE0M.AssertModel(models[0],_testData[30], false);
                DateTimedatetimeE0M.AssertModel(models[1],_testData[31], false);
                DateTimedatetimeE0M.AssertModel(models[2],_testData[32], false);
                DateTimedatetimeE0M.AssertModel(models[3],_testData[33], false);
                DateTimedatetimeE0M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                DateTimedatetimeE0M.AssertModel(models[0],_testData[16], false);
                DateTimedatetimeE0M.AssertModel(models[1],_testData[17], false);
                DateTimedatetimeE0M.AssertModel(models[2],_testData[18], false);
                DateTimedatetimeE0M.AssertModel(models[3],_testData[19], false);
                DateTimedatetimeE0M.AssertModel(models[4],_testData[20], false);
                DateTimedatetimeE0M.AssertModel(models[5],_testData[21], false);
                DateTimedatetimeE0M.AssertModel(models[6],_testData[22], false);
                DateTimedatetimeE0M.AssertModel(models[7],_testData[23], false);
                DateTimedatetimeE0M.AssertModel(models[8],_testData[24], false);
                DateTimedatetimeE0M.AssertModel(models[9],_testData[25], false);
                DateTimedatetimeE0M.AssertModel(models[10],_testData[26], false);
                DateTimedatetimeE0M.AssertModel(models[11],_testData[27], false);
                DateTimedatetimeE0M.AssertModel(models[12],_testData[28], false);
                DateTimedatetimeE0M.AssertModel(models[13],_testData[29], false);
                DateTimedatetimeE0M.AssertModel(models[14],_testData[30], false);
                DateTimedatetimeE0M.AssertModel(models[15],_testData[31], false);
                DateTimedatetimeE0M.AssertModel(models[16],_testData[32], false);
                DateTimedatetimeE0M.AssertModel(models[17],_testData[33], false);
                DateTimedatetimeE0M.AssertModel(models[18],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 12, hour: 3, minute: 46, second: 54, millisecond: 902, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 6, hour: 19, minute: 30, second: 45, millisecond: 677, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 5, minute: 37, second: 34, millisecond: 200, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 13, hour: 19, minute: 50, second: 44, millisecond: 518, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 8, hour: 15, minute: 52, second: 35, millisecond: 298, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 5, hour: 20, minute: 48, second: 11, millisecond: 884, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 8, hour: 14, minute: 19, second: 32, millisecond: 263, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 10, hour: 22, minute: 47, second: 30, millisecond: 152, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 9, hour: 3, minute: 50, second: 54, millisecond: 264, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 18, hour: 21, minute: 46, second: 19, millisecond: 219, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 9, hour: 15, minute: 22, second: 22, millisecond: 235, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 8, second: 55, millisecond: 341, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 2, hour: 19, minute: 24, second: 23, millisecond: 130, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 12, hour: 12, minute: 39, second: 38, millisecond: 410, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 8, hour: 2, minute: 13, second: 26, millisecond: 106, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 8, hour: 4, minute: 42, second: 56, millisecond: 835, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 15, hour: 15, minute: 43, second: 20, millisecond: 688, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 12, hour: 12, minute: 26, second: 23, millisecond: 518, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 9, hour: 3, minute: 14, second: 50, millisecond: 285, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 3, hour: 20, minute: 53, second: 19, millisecond: 636, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 8, hour: 3, minute: 31, second: 51, millisecond: 27, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 19, hour: 14, minute: 32, second: 26, millisecond: 191, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 4, hour: 1, minute: 13, second: 18, millisecond: 515, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 12, hour: 12, minute: 1, second: 29, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 3, minute: 48, second: 29, millisecond: 440, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 18, hour: 19, minute: 31, second: 55, millisecond: 788, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 18, hour: 10, minute: 54, second: 28, millisecond: 578, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 19, hour: 3, minute: 5, second: 7, millisecond: 203, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 18, hour: 20, minute: 53, second: 32, millisecond: 416, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 8, hour: 9, minute: 54, second: 40, millisecond: 665, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 18, hour: 8, minute: 16, second: 33, millisecond: 661, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 8, hour: 20, minute: 23, second: 44, millisecond: 373, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 28, second: 52, millisecond: 612, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 5, hour: 6, minute: 27, second: 21, millisecond: 687, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 5, hour: 4, minute: 11, second: 13, millisecond: 319, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 4, hour: 1, minute: 47, second: 10, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 17, hour: 16, minute: 40, second: 53, millisecond: 643, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 12, hour: 6, minute: 1, second: 27, millisecond: 493, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 6, hour: 10, minute: 9, second: 10, millisecond: 245, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 13, minute: 17, second: 24, millisecond: 238, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 12, hour: 11, minute: 54, second: 17, millisecond: 912, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 4, hour: 10, minute: 34, second: 23, millisecond: 400, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 1, hour: 20, minute: 25, second: 48, millisecond: 630, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 49, second: 55, millisecond: 707, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 9, hour: 6, minute: 18, second: 41, millisecond: 116, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 11, hour: 6, minute: 17, second: 52, millisecond: 777, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 19, hour: 6, minute: 22, second: 57, millisecond: 189, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 3, hour: 1, minute: 9, second: 53, millisecond: 556, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 3, minute: 46, second: 49, millisecond: 802, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 5, hour: 12, minute: 29, second: 50, millisecond: 263, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 14, hour: 18, minute: 47, second: 49, millisecond: 237, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 1, minute: 56, second: 58, millisecond: 73, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 13, hour: 4, minute: 34, second: 41, millisecond: 133, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 16, hour: 21, minute: 7, second: 32, millisecond: 463, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 18, hour: 16, minute: 53, second: 22, millisecond: 971, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 17, minute: 53, second: 30, millisecond: 529, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 3, minute: 35, second: 39, millisecond: 207, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 11, hour: 22, minute: 13, second: 8, millisecond: 343, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 8, hour: 21, minute: 20, second: 21, millisecond: 50, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 9, hour: 11, minute: 28, second: 46, millisecond: 158, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 9, hour: 22, minute: 45, second: 28, millisecond: 528, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 16, hour: 5, minute: 55, second: 4, millisecond: 966, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 10, hour: 6, minute: 36, second: 1, millisecond: 587, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 19, hour: 7, minute: 5, second: 8, millisecond: 876, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 14, hour: 22, minute: 14, second: 17, millisecond: 917, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 6, hour: 10, minute: 39, second: 56, millisecond: 502, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 12, hour: 22, minute: 51, second: 20, millisecond: 990, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 4, hour: 16, minute: 35, second: 50, millisecond: 919, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 13, hour: 4, minute: 53, second: 57, millisecond: 514, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 5, hour: 20, minute: 14, second: 40, millisecond: 95, kind: DateTimeKind.Local))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 12, hour: 16, minute: 54, second: 16, millisecond: 992, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 31, second: 25, millisecond: 476, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 19, hour: 12, minute: 55, second: 8, millisecond: 918, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 9, hour: 8, minute: 58, second: 51, millisecond: 433, kind: DateTimeKind.Local))));//Value

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
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 12, hour: 3, minute: 46, second: 54, millisecond: 902, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 6, hour: 19, minute: 30, second: 45, millisecond: 677, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 5, minute: 37, second: 34, millisecond: 200, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 13, hour: 19, minute: 50, second: 44, millisecond: 518, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 8, hour: 15, minute: 52, second: 35, millisecond: 298, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 5, hour: 20, minute: 48, second: 11, millisecond: 884, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 8, hour: 14, minute: 19, second: 32, millisecond: 263, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 10, hour: 22, minute: 47, second: 30, millisecond: 152, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 9, hour: 3, minute: 50, second: 54, millisecond: 264, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 18, hour: 21, minute: 46, second: 19, millisecond: 219, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 9, hour: 15, minute: 22, second: 22, millisecond: 235, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 8, second: 55, millisecond: 341, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 2, hour: 19, minute: 24, second: 23, millisecond: 130, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 12, hour: 12, minute: 39, second: 38, millisecond: 410, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 8, hour: 2, minute: 13, second: 26, millisecond: 106, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 8, hour: 4, minute: 42, second: 56, millisecond: 835, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 15, hour: 15, minute: 43, second: 20, millisecond: 688, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 12, hour: 12, minute: 26, second: 23, millisecond: 518, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 9, hour: 3, minute: 14, second: 50, millisecond: 285, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 3, hour: 20, minute: 53, second: 19, millisecond: 636, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 8, hour: 3, minute: 31, second: 51, millisecond: 27, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 19, hour: 14, minute: 32, second: 26, millisecond: 191, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 4, hour: 1, minute: 13, second: 18, millisecond: 515, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 12, hour: 12, minute: 1, second: 29, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 3, minute: 48, second: 29, millisecond: 440, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 18, hour: 19, minute: 31, second: 55, millisecond: 788, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 18, hour: 10, minute: 54, second: 28, millisecond: 578, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 19, hour: 3, minute: 5, second: 7, millisecond: 203, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 18, hour: 20, minute: 53, second: 32, millisecond: 416, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 8, hour: 9, minute: 54, second: 40, millisecond: 665, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 18, hour: 8, minute: 16, second: 33, millisecond: 661, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 8, hour: 20, minute: 23, second: 44, millisecond: 373, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 28, second: 52, millisecond: 612, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 5, hour: 6, minute: 27, second: 21, millisecond: 687, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 5, hour: 4, minute: 11, second: 13, millisecond: 319, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 4, hour: 1, minute: 47, second: 10, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 17, hour: 16, minute: 40, second: 53, millisecond: 643, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 12, hour: 6, minute: 1, second: 27, millisecond: 493, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 6, hour: 10, minute: 9, second: 10, millisecond: 245, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 13, minute: 17, second: 24, millisecond: 238, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 12, hour: 11, minute: 54, second: 17, millisecond: 912, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 4, hour: 10, minute: 34, second: 23, millisecond: 400, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 1, hour: 20, minute: 25, second: 48, millisecond: 630, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 10, hour: 15, minute: 49, second: 55, millisecond: 707, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 9, hour: 6, minute: 18, second: 41, millisecond: 116, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 11, hour: 6, minute: 17, second: 52, millisecond: 777, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 19, hour: 6, minute: 22, second: 57, millisecond: 189, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 3, hour: 1, minute: 9, second: 53, millisecond: 556, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 3, minute: 46, second: 49, millisecond: 802, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 5, hour: 12, minute: 29, second: 50, millisecond: 263, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 14, hour: 18, minute: 47, second: 49, millisecond: 237, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 1, minute: 56, second: 58, millisecond: 73, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 13, hour: 4, minute: 34, second: 41, millisecond: 133, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 16, hour: 21, minute: 7, second: 32, millisecond: 463, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 18, hour: 16, minute: 53, second: 22, millisecond: 971, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 17, minute: 53, second: 30, millisecond: 529, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 3, minute: 35, second: 39, millisecond: 207, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 11, hour: 22, minute: 13, second: 8, millisecond: 343, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 8, hour: 21, minute: 20, second: 21, millisecond: 50, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 9, hour: 11, minute: 28, second: 46, millisecond: 158, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 9, hour: 22, minute: 45, second: 28, millisecond: 528, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 16, hour: 5, minute: 55, second: 4, millisecond: 966, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 10, hour: 6, minute: 36, second: 1, millisecond: 587, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 19, hour: 7, minute: 5, second: 8, millisecond: 876, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 14, hour: 22, minute: 14, second: 17, millisecond: 917, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 6, hour: 10, minute: 39, second: 56, millisecond: 502, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 12, hour: 22, minute: 51, second: 20, millisecond: 990, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 4, hour: 16, minute: 35, second: 50, millisecond: 919, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 13, hour: 4, minute: 53, second: 57, millisecond: 514, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 5, hour: 20, minute: 14, second: 40, millisecond: 95, kind: DateTimeKind.Local))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 12, hour: 16, minute: 54, second: 16, millisecond: 992, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 31, second: 25, millisecond: 476, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 19, hour: 12, minute: 55, second: 8, millisecond: 918, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 9, hour: 8, minute: 58, second: 51, millisecond: 433, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


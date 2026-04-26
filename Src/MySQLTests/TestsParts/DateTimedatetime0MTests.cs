

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

        private readonly DateTimedatetime0M[] _testData = new DateTimedatetime0M[]
        {
            new DateTimedatetime0M
{
    Id = 9,
    Value = new DateTime(year: 2018, month: 10, day: 15, hour: 13, minute: 33, second: 12, millisecond: 667, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1943, month: 10, day: 5, hour: 7, minute: 43, second: 12, millisecond: 253, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 18,
    Value = new DateTime(year: 1928, month: 10, day: 6, hour: 4, minute: 32, second: 32, millisecond: 498, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 1,
    Value = new DateTime(year: 1964, month: 10, day: 12, hour: 2, minute: 14, second: 56, millisecond: 304, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1943, month: 10, day: 1, hour: 4, minute: 53, second: 30, millisecond: 548, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1985, month: 10, day: 8, hour: 7, minute: 47, second: 58, millisecond: 88, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 24,
    Value = new DateTime(year: 1968, month: 10, day: 6, hour: 5, minute: 41, second: 39, millisecond: 448, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1931, month: 10, day: 4, hour: 8, minute: 32, second: 33, millisecond: 11, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 25,
    Value = new DateTime(year: 1953, month: 10, day: 7, hour: 13, minute: 50, second: 41, millisecond: 27, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 6,
    Value = new DateTime(year: 1966, month: 10, day: 9, hour: 9, minute: 27, second: 56, millisecond: 159, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1955, month: 10, day: 5, hour: 13, minute: 56, second: 20, millisecond: 429, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 34,
    Value = new DateTime(year: 1964, month: 10, day: 3, hour: 8, minute: 53, second: 34, millisecond: 440, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 36,
    Value = new DateTime(year: 2001, month: 10, day: 19, hour: 16, minute: 4, second: 16, millisecond: 13, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 11,
    Value = new DateTime(year: 1977, month: 10, day: 3, hour: 20, minute: 43, second: 26, millisecond: 379, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1995, month: 10, day: 8, hour: 12, minute: 58, second: 30, millisecond: 116, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 39,
    Value = new DateTime(year: 2002, month: 10, day: 6, hour: 11, minute: 9, second: 18, millisecond: 833, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1927, month: 10, day: 7, hour: 3, minute: 16, second: 16, millisecond: 34, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 41,
    Value = new DateTime(year: 1925, month: 10, day: 3, hour: 20, minute: 34, second: 30, millisecond: 941, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 13,
    Value = new DateTime(year: 2012, month: 10, day: 1, hour: 1, minute: 42, second: 40, millisecond: 268, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1953, month: 10, day: 7, hour: 10, minute: 46, second: 28, millisecond: 704, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 47,
    Value = new DateTime(year: 1940, month: 10, day: 8, hour: 17, minute: 54, second: 8, millisecond: 786, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1998, month: 10, day: 16, hour: 18, minute: 24, second: 34, millisecond: 813, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 56,
    Value = new DateTime(year: 1954, month: 10, day: 16, hour: 14, minute: 52, second: 31, millisecond: 257, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 21,
    Value = new DateTime(year: 2013, month: 10, day: 13, hour: 1, minute: 43, second: 16, millisecond: 920, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 58,
    Value = new DateTime(year: 1935, month: 10, day: 3, hour: 19, minute: 29, second: 56, millisecond: 264, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1950, month: 10, day: 12, hour: 6, minute: 16, second: 55, millisecond: 531, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 65,
    Value = new DateTime(year: 2000, month: 10, day: 9, hour: 18, minute: 39, second: 25, millisecond: 710, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 28,
    Value = new DateTime(year: 1938, month: 10, day: 19, hour: 15, minute: 51, second: 37, millisecond: 964, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 45, second: 4, millisecond: 667, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1980, month: 10, day: 4, hour: 19, minute: 32, second: 54, millisecond: 680, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 69,
    Value = new DateTime(year: 1985, month: 10, day: 2, hour: 2, minute: 12, second: 54, millisecond: 853, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1924, month: 10, day: 18, hour: 7, minute: 44, second: 47, millisecond: 452, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 76,
    Value = new DateTime(year: 1929, month: 10, day: 16, hour: 5, minute: 31, second: 20, millisecond: 539, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 30,
    Value = new DateTime(year: 2019, month: 10, day: 9, hour: 2, minute: 12, second: 20, millisecond: 437, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2018, month: 10, day: 12, hour: 16, minute: 10, second: 32, millisecond: 345, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 83,
    Value = new DateTime(year: 1939, month: 10, day: 11, hour: 11, minute: 10, second: 9, millisecond: 419, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 91,
    Value = new DateTime(year: 1946, month: 10, day: 6, hour: 10, minute: 12, second: 45, millisecond: 120, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 39,
    Value = new DateTime(year: 1969, month: 10, day: 4, hour: 18, minute: 17, second: 30, millisecond: 776, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1955, month: 10, day: 12, hour: 15, minute: 14, second: 10, millisecond: 413, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 97,
    Value = new DateTime(year: 1998, month: 10, day: 6, hour: 16, minute: 9, second: 10, millisecond: 523, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1965, month: 10, day: 4, hour: 4, minute: 44, second: 42, millisecond: 360, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 100,
    Value = new DateTime(year: 1998, month: 10, day: 8, hour: 10, minute: 33, second: 48, millisecond: 755, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 47,
    Value = new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 40, second: 55, millisecond: 854, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 109,
    Value = new DateTime(year: 1962, month: 10, day: 4, hour: 15, minute: 7, second: 36, millisecond: 265, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1938, month: 10, day: 15, hour: 17, minute: 37, second: 44, millisecond: 350, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 113,
    Value = new DateTime(year: 1979, month: 10, day: 7, hour: 7, minute: 25, second: 36, millisecond: 656, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 49,
    Value = new DateTime(year: 1978, month: 10, day: 15, hour: 6, minute: 56, second: 58, millisecond: 891, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1999, month: 10, day: 7, hour: 9, minute: 50, second: 55, millisecond: 633, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 115,
    Value = new DateTime(year: 1993, month: 10, day: 14, hour: 7, minute: 38, second: 22, millisecond: 561, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 122,
    Value = new DateTime(year: 2002, month: 10, day: 4, hour: 4, minute: 1, second: 4, millisecond: 267, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 53,
    Value = new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 6, second: 57, millisecond: 657, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1977, month: 10, day: 7, hour: 16, minute: 28, second: 51, millisecond: 318, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 124,
    Value = new DateTime(year: 1939, month: 10, day: 4, hour: 19, minute: 5, second: 23, millisecond: 65, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 131,
    Value = new DateTime(year: 1940, month: 10, day: 5, hour: 15, minute: 4, second: 56, millisecond: 480, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 60,
    Value = new DateTime(year: 1947, month: 10, day: 7, hour: 3, minute: 3, second: 31, millisecond: 203, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1965, month: 10, day: 8, hour: 18, minute: 9, second: 55, millisecond: 605, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 140,
    Value = new DateTime(year: 1940, month: 10, day: 11, hour: 1, minute: 37, second: 16, millisecond: 404, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 146,
    Value = new DateTime(year: 2012, month: 10, day: 10, hour: 12, minute: 23, second: 11, millisecond: 803, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 66,
    Value = new DateTime(year: 1963, month: 10, day: 11, hour: 1, minute: 5, second: 29, millisecond: 773, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1940, month: 10, day: 8, hour: 9, minute: 14, second: 57, millisecond: 911, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 147,
    Value = new DateTime(year: 2009, month: 10, day: 16, hour: 9, minute: 28, second: 55, millisecond: 325, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2015, month: 10, day: 9, hour: 18, minute: 21, second: 27, millisecond: 621, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 151,
    Value = new DateTime(year: 1944, month: 10, day: 17, hour: 17, minute: 18, second: 45, millisecond: 216, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 70,
    Value = new DateTime(year: 1931, month: 10, day: 12, hour: 12, minute: 38, second: 24, millisecond: 626, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1993, month: 10, day: 8, hour: 7, minute: 43, second: 34, millisecond: 991, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 58, second: 34, millisecond: 96, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 152,
    Value = new DateTime(year: 1994, month: 10, day: 13, hour: 9, minute: 57, second: 54, millisecond: 254, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1934, month: 10, day: 2, hour: 2, minute: 34, second: 36, millisecond: 45, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 155,
    Value = new DateTime(year: 1948, month: 10, day: 2, hour: 8, minute: 52, second: 19, millisecond: 394, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 73,
    Value = new DateTime(year: 2002, month: 10, day: 17, hour: 11, minute: 18, second: 46, millisecond: 7, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0mi(
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
INSERT INTO gedaqtests.datetimedatetime0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0m(
	id,
    value,
    nullablevalue,
    datetimedatetime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime0mi_id
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
                parametrName: "datetimedatetime0mi_id", 
                methodParametrName: "datetimedatetime0mi_id", 
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
INSERT INTO gedaqtests.datetimedatetime0m(
	id,
    value,
    nullablevalue,
    datetimedatetime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime0mi_id
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
                parametrName: "datetimedatetime0mi_id", 
                methodParametrName: "datetimedatetime0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeSingleTypedatetime)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeSingleTypedatetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime0M)],
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

                var models = await ((IDateTimeSingleTypedatetime)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDateTimeSingleTypedatetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypedatetime)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeSingleTypedatetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimedatetime0M)],
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
                var models = await ((IDateTimeSingleTypedatetime)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypedatetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[5], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[6], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[7], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[8], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[9], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[10], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[11], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[12], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[13], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[14], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[15], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[16], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[13],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[14],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[15],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[16],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[17],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[18],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[19],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[20],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[21],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[22],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[23],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[29], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[11], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[12], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[13], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[14], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[15], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[16], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[13],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[14],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[15],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[16],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[17],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[8], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[9], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[10], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[11], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[12], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[13], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[14], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[15], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[16], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[13],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[14],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[15],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[16],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[17],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[18],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[19],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[20],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[21],_testData[29], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime0M)],
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DateTimedatetime0M.AssertModel(models[0],_testData[7], false);DateTimedatetime0M.AssertModel(models[1],_testData[8], false);DateTimedatetime0M.AssertModel(models[2],_testData[9], false);DateTimedatetime0M.AssertModel(models[3],_testData[10], false);DateTimedatetime0M.AssertModel(models[4],_testData[11], false);DateTimedatetime0M.AssertModel(models[5],_testData[12], false);DateTimedatetime0M.AssertModel(models[6],_testData[13], false);DateTimedatetime0M.AssertModel(models[7],_testData[14], false);DateTimedatetime0M.AssertModel(models[8],_testData[15], false);DateTimedatetime0M.AssertModel(models[9],_testData[16], false);DateTimedatetime0M.AssertModel(models[10],_testData[17], false);DateTimedatetime0M.AssertModel(models[11],_testData[18], false);DateTimedatetime0M.AssertModel(models[12],_testData[19], false);DateTimedatetime0M.AssertModel(models[13],_testData[20], false);DateTimedatetime0M.AssertModel(models[14],_testData[21], false);DateTimedatetime0M.AssertModel(models[15],_testData[22], false);DateTimedatetime0M.AssertModel(models[16],_testData[23], false);DateTimedatetime0M.AssertModel(models[17],_testData[24], false);DateTimedatetime0M.AssertModel(models[18],_testData[25], false);DateTimedatetime0M.AssertModel(models[19],_testData[26], false);DateTimedatetime0M.AssertModel(models[20],_testData[27], false);DateTimedatetime0M.AssertModel(models[21],_testData[28], false);DateTimedatetime0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
DateTimedatetime0M.AssertModel(models[0],_testData[10], false);DateTimedatetime0M.AssertModel(models[1],_testData[11], false);DateTimedatetime0M.AssertModel(models[2],_testData[12], false);DateTimedatetime0M.AssertModel(models[3],_testData[13], false);DateTimedatetime0M.AssertModel(models[4],_testData[14], false);DateTimedatetime0M.AssertModel(models[5],_testData[15], false);DateTimedatetime0M.AssertModel(models[6],_testData[16], false);DateTimedatetime0M.AssertModel(models[7],_testData[17], false);DateTimedatetime0M.AssertModel(models[8],_testData[18], false);DateTimedatetime0M.AssertModel(models[9],_testData[19], false);DateTimedatetime0M.AssertModel(models[10],_testData[20], false);DateTimedatetime0M.AssertModel(models[11],_testData[21], false);DateTimedatetime0M.AssertModel(models[12],_testData[22], false);DateTimedatetime0M.AssertModel(models[13],_testData[23], false);DateTimedatetime0M.AssertModel(models[14],_testData[24], false);DateTimedatetime0M.AssertModel(models[15],_testData[25], false);DateTimedatetime0M.AssertModel(models[16],_testData[26], false);DateTimedatetime0M.AssertModel(models[17],_testData[27], false);DateTimedatetime0M.AssertModel(models[18],_testData[28], false);DateTimedatetime0M.AssertModel(models[19],_testData[29], false);
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

                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
DateTimedatetime0M.AssertModel(models[0],_testData[17], false);DateTimedatetime0M.AssertModel(models[1],_testData[18], false);DateTimedatetime0M.AssertModel(models[2],_testData[19], false);DateTimedatetime0M.AssertModel(models[3],_testData[20], false);DateTimedatetime0M.AssertModel(models[4],_testData[21], false);DateTimedatetime0M.AssertModel(models[5],_testData[22], false);DateTimedatetime0M.AssertModel(models[6],_testData[23], false);DateTimedatetime0M.AssertModel(models[7],_testData[24], false);DateTimedatetime0M.AssertModel(models[8],_testData[25], false);DateTimedatetime0M.AssertModel(models[9],_testData[26], false);DateTimedatetime0M.AssertModel(models[10],_testData[27], false);DateTimedatetime0M.AssertModel(models[11],_testData[28], false);DateTimedatetime0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DateTimedatetime0M.AssertModel(models[0],_testData[4], false);DateTimedatetime0M.AssertModel(models[1],_testData[5], false);DateTimedatetime0M.AssertModel(models[2],_testData[6], false);DateTimedatetime0M.AssertModel(models[3],_testData[7], false);DateTimedatetime0M.AssertModel(models[4],_testData[8], false);DateTimedatetime0M.AssertModel(models[5],_testData[9], false);DateTimedatetime0M.AssertModel(models[6],_testData[10], false);DateTimedatetime0M.AssertModel(models[7],_testData[11], false);DateTimedatetime0M.AssertModel(models[8],_testData[12], false);DateTimedatetime0M.AssertModel(models[9],_testData[13], false);DateTimedatetime0M.AssertModel(models[10],_testData[14], false);DateTimedatetime0M.AssertModel(models[11],_testData[15], false);DateTimedatetime0M.AssertModel(models[12],_testData[16], false);DateTimedatetime0M.AssertModel(models[13],_testData[17], false);DateTimedatetime0M.AssertModel(models[14],_testData[18], false);DateTimedatetime0M.AssertModel(models[15],_testData[19], false);DateTimedatetime0M.AssertModel(models[16],_testData[20], false);DateTimedatetime0M.AssertModel(models[17],_testData[21], false);DateTimedatetime0M.AssertModel(models[18],_testData[22], false);DateTimedatetime0M.AssertModel(models[19],_testData[23], false);DateTimedatetime0M.AssertModel(models[20],_testData[24], false);DateTimedatetime0M.AssertModel(models[21],_testData[25], false);DateTimedatetime0M.AssertModel(models[22],_testData[26], false);DateTimedatetime0M.AssertModel(models[23],_testData[27], false);DateTimedatetime0M.AssertModel(models[24],_testData[28], false);DateTimedatetime0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[4], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[5], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[6], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[7], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[8], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[9], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[10], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[11], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[12], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[13], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[14], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[15], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[16], false);FlatDateTimedatetime0M.AssertModel(models[13],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[14],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[15],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[16],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[17],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[18],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[19],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[20],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[21],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[22],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[23],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[24],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[5], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[6], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[7], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[8], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[9], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[10], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[11], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[12], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[13], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[14], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[15], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[16], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[13],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[14],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[15],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[16],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[17],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[18],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[19],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[20],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[21],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[22],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[23],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[24],_testData[29], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatDateTimedatetime0M.AssertModel(models[0],_testData[17], false);FlatDateTimedatetime0M.AssertModel(models[1],_testData[18], false);FlatDateTimedatetime0M.AssertModel(models[2],_testData[19], false);FlatDateTimedatetime0M.AssertModel(models[3],_testData[20], false);FlatDateTimedatetime0M.AssertModel(models[4],_testData[21], false);FlatDateTimedatetime0M.AssertModel(models[5],_testData[22], false);FlatDateTimedatetime0M.AssertModel(models[6],_testData[23], false);FlatDateTimedatetime0M.AssertModel(models[7],_testData[24], false);FlatDateTimedatetime0M.AssertModel(models[8],_testData[25], false);FlatDateTimedatetime0M.AssertModel(models[9],_testData[26], false);FlatDateTimedatetime0M.AssertModel(models[10],_testData[27], false);FlatDateTimedatetime0M.AssertModel(models[11],_testData[28], false);FlatDateTimedatetime0M.AssertModel(models[12],_testData[29], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimedatetime0M)],
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelBatchAsync(connection, 140, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DateTimedatetime0M.AssertModel(models[0],_testData[25], false);DateTimedatetime0M.AssertModel(models[1],_testData[26], false);DateTimedatetime0M.AssertModel(models[2],_testData[27], false);DateTimedatetime0M.AssertModel(models[3],_testData[28], false);DateTimedatetime0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
DateTimedatetime0M.AssertModel(models[0],_testData[22], false);DateTimedatetime0M.AssertModel(models[1],_testData[23], false);DateTimedatetime0M.AssertModel(models[2],_testData[24], false);DateTimedatetime0M.AssertModel(models[3],_testData[25], false);DateTimedatetime0M.AssertModel(models[4],_testData[26], false);DateTimedatetime0M.AssertModel(models[5],_testData[27], false);DateTimedatetime0M.AssertModel(models[6],_testData[28], false);DateTimedatetime0M.AssertModel(models[7],_testData[29], false);
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
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelBatch(connection, 18, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DateTimedatetime0M.AssertModel(models[0],_testData[2], false);DateTimedatetime0M.AssertModel(models[1],_testData[3], false);DateTimedatetime0M.AssertModel(models[2],_testData[4], false);DateTimedatetime0M.AssertModel(models[3],_testData[5], false);DateTimedatetime0M.AssertModel(models[4],_testData[6], false);DateTimedatetime0M.AssertModel(models[5],_testData[7], false);DateTimedatetime0M.AssertModel(models[6],_testData[8], false);DateTimedatetime0M.AssertModel(models[7],_testData[9], false);DateTimedatetime0M.AssertModel(models[8],_testData[10], false);DateTimedatetime0M.AssertModel(models[9],_testData[11], false);DateTimedatetime0M.AssertModel(models[10],_testData[12], false);DateTimedatetime0M.AssertModel(models[11],_testData[13], false);DateTimedatetime0M.AssertModel(models[12],_testData[14], false);DateTimedatetime0M.AssertModel(models[13],_testData[15], false);DateTimedatetime0M.AssertModel(models[14],_testData[16], false);DateTimedatetime0M.AssertModel(models[15],_testData[17], false);DateTimedatetime0M.AssertModel(models[16],_testData[18], false);DateTimedatetime0M.AssertModel(models[17],_testData[19], false);DateTimedatetime0M.AssertModel(models[18],_testData[20], false);DateTimedatetime0M.AssertModel(models[19],_testData[21], false);DateTimedatetime0M.AssertModel(models[20],_testData[22], false);DateTimedatetime0M.AssertModel(models[21],_testData[23], false);DateTimedatetime0M.AssertModel(models[22],_testData[24], false);DateTimedatetime0M.AssertModel(models[23],_testData[25], false);DateTimedatetime0M.AssertModel(models[24],_testData[26], false);DateTimedatetime0M.AssertModel(models[25],_testData[27], false);DateTimedatetime0M.AssertModel(models[26],_testData[28], false);DateTimedatetime0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DateTimedatetime0M.AssertModel(models[0],_testData[14], false);DateTimedatetime0M.AssertModel(models[1],_testData[15], false);DateTimedatetime0M.AssertModel(models[2],_testData[16], false);DateTimedatetime0M.AssertModel(models[3],_testData[17], false);DateTimedatetime0M.AssertModel(models[4],_testData[18], false);DateTimedatetime0M.AssertModel(models[5],_testData[19], false);DateTimedatetime0M.AssertModel(models[6],_testData[20], false);DateTimedatetime0M.AssertModel(models[7],_testData[21], false);DateTimedatetime0M.AssertModel(models[8],_testData[22], false);DateTimedatetime0M.AssertModel(models[9],_testData[23], false);DateTimedatetime0M.AssertModel(models[10],_testData[24], false);DateTimedatetime0M.AssertModel(models[11],_testData[25], false);DateTimedatetime0M.AssertModel(models[12],_testData[26], false);DateTimedatetime0M.AssertModel(models[13],_testData[27], false);DateTimedatetime0M.AssertModel(models[14],_testData[28], false);DateTimedatetime0M.AssertModel(models[15],_testData[29], false);
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
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
DateTimedatetime0M.AssertModel(models[0],_testData[14], false);DateTimedatetime0M.AssertModel(models[1],_testData[15], false);DateTimedatetime0M.AssertModel(models[2],_testData[16], false);DateTimedatetime0M.AssertModel(models[3],_testData[17], false);DateTimedatetime0M.AssertModel(models[4],_testData[18], false);DateTimedatetime0M.AssertModel(models[5],_testData[19], false);DateTimedatetime0M.AssertModel(models[6],_testData[20], false);DateTimedatetime0M.AssertModel(models[7],_testData[21], false);DateTimedatetime0M.AssertModel(models[8],_testData[22], false);DateTimedatetime0M.AssertModel(models[9],_testData[23], false);DateTimedatetime0M.AssertModel(models[10],_testData[24], false);DateTimedatetime0M.AssertModel(models[11],_testData[25], false);DateTimedatetime0M.AssertModel(models[12],_testData[26], false);DateTimedatetime0M.AssertModel(models[13],_testData[27], false);DateTimedatetime0M.AssertModel(models[14],_testData[28], false);DateTimedatetime0M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
DateTimedatetime0M.AssertModel(models[0],_testData[9], false);DateTimedatetime0M.AssertModel(models[1],_testData[10], false);DateTimedatetime0M.AssertModel(models[2],_testData[11], false);DateTimedatetime0M.AssertModel(models[3],_testData[12], false);DateTimedatetime0M.AssertModel(models[4],_testData[13], false);DateTimedatetime0M.AssertModel(models[5],_testData[14], false);DateTimedatetime0M.AssertModel(models[6],_testData[15], false);DateTimedatetime0M.AssertModel(models[7],_testData[16], false);DateTimedatetime0M.AssertModel(models[8],_testData[17], false);DateTimedatetime0M.AssertModel(models[9],_testData[18], false);DateTimedatetime0M.AssertModel(models[10],_testData[19], false);DateTimedatetime0M.AssertModel(models[11],_testData[20], false);DateTimedatetime0M.AssertModel(models[12],_testData[21], false);DateTimedatetime0M.AssertModel(models[13],_testData[22], false);DateTimedatetime0M.AssertModel(models[14],_testData[23], false);DateTimedatetime0M.AssertModel(models[15],_testData[24], false);DateTimedatetime0M.AssertModel(models[16],_testData[25], false);DateTimedatetime0M.AssertModel(models[17],_testData[26], false);DateTimedatetime0M.AssertModel(models[18],_testData[27], false);DateTimedatetime0M.AssertModel(models[19],_testData[28], false);DateTimedatetime0M.AssertModel(models[20],_testData[29], false);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 15, hour: 13, minute: 33, second: 12, millisecond: 667, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 5, hour: 7, minute: 43, second: 12, millisecond: 253, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 6, hour: 4, minute: 32, second: 32, millisecond: 498, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 12, hour: 2, minute: 14, second: 56, millisecond: 304, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 1, hour: 4, minute: 53, second: 30, millisecond: 548, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 8, hour: 7, minute: 47, second: 58, millisecond: 88, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 6, hour: 5, minute: 41, second: 39, millisecond: 448, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 4, hour: 8, minute: 32, second: 33, millisecond: 11, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 7, hour: 13, minute: 50, second: 41, millisecond: 27, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 9, hour: 9, minute: 27, second: 56, millisecond: 159, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 5, hour: 13, minute: 56, second: 20, millisecond: 429, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 3, hour: 8, minute: 53, second: 34, millisecond: 440, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 19, hour: 16, minute: 4, second: 16, millisecond: 13, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 3, hour: 20, minute: 43, second: 26, millisecond: 379, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 8, hour: 12, minute: 58, second: 30, millisecond: 116, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 6, hour: 11, minute: 9, second: 18, millisecond: 833, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 3, minute: 16, second: 16, millisecond: 34, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 3, hour: 20, minute: 34, second: 30, millisecond: 941, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 1, hour: 1, minute: 42, second: 40, millisecond: 268, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 7, hour: 10, minute: 46, second: 28, millisecond: 704, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 17, minute: 54, second: 8, millisecond: 786, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 16, hour: 18, minute: 24, second: 34, millisecond: 813, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 16, hour: 14, minute: 52, second: 31, millisecond: 257, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 1, minute: 43, second: 16, millisecond: 920, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 3, hour: 19, minute: 29, second: 56, millisecond: 264, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 12, hour: 6, minute: 16, second: 55, millisecond: 531, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 9, hour: 18, minute: 39, second: 25, millisecond: 710, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 19, hour: 15, minute: 51, second: 37, millisecond: 964, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 45, second: 4, millisecond: 667, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 4, hour: 19, minute: 32, second: 54, millisecond: 680, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 2, hour: 2, minute: 12, second: 54, millisecond: 853, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 18, hour: 7, minute: 44, second: 47, millisecond: 452, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 16, hour: 5, minute: 31, second: 20, millisecond: 539, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 9, hour: 2, minute: 12, second: 20, millisecond: 437, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 12, hour: 16, minute: 10, second: 32, millisecond: 345, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 11, hour: 11, minute: 10, second: 9, millisecond: 419, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 6, hour: 10, minute: 12, second: 45, millisecond: 120, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 4, hour: 18, minute: 17, second: 30, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 12, hour: 15, minute: 14, second: 10, millisecond: 413, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 6, hour: 16, minute: 9, second: 10, millisecond: 523, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 4, minute: 44, second: 42, millisecond: 360, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 8, hour: 10, minute: 33, second: 48, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 40, second: 55, millisecond: 854, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 4, hour: 15, minute: 7, second: 36, millisecond: 265, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 15, hour: 17, minute: 37, second: 44, millisecond: 350, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 7, hour: 7, minute: 25, second: 36, millisecond: 656, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 15, hour: 6, minute: 56, second: 58, millisecond: 891, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 7, hour: 9, minute: 50, second: 55, millisecond: 633, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 14, hour: 7, minute: 38, second: 22, millisecond: 561, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 4, hour: 4, minute: 1, second: 4, millisecond: 267, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 6, second: 57, millisecond: 657, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 7, hour: 16, minute: 28, second: 51, millisecond: 318, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 4, hour: 19, minute: 5, second: 23, millisecond: 65, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 5, hour: 15, minute: 4, second: 56, millisecond: 480, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 7, hour: 3, minute: 3, second: 31, millisecond: 203, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 8, hour: 18, minute: 9, second: 55, millisecond: 605, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 1, minute: 37, second: 16, millisecond: 404, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 10, hour: 12, minute: 23, second: 11, millisecond: 803, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 11, hour: 1, minute: 5, second: 29, millisecond: 773, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 9, minute: 14, second: 57, millisecond: 911, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 16, hour: 9, minute: 28, second: 55, millisecond: 325, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 9, hour: 18, minute: 21, second: 27, millisecond: 621, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 17, hour: 17, minute: 18, second: 45, millisecond: 216, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 12, hour: 12, minute: 38, second: 24, millisecond: 626, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 8, hour: 7, minute: 43, second: 34, millisecond: 991, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 58, second: 34, millisecond: 96, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 13, hour: 9, minute: 57, second: 54, millisecond: 254, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 2, hour: 2, minute: 34, second: 36, millisecond: 45, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 2, hour: 8, minute: 52, second: 19, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 17, hour: 11, minute: 18, second: 46, millisecond: 7, kind: DateTimeKind.Local))));//InnerModel.Value

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
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 15, hour: 13, minute: 33, second: 12, millisecond: 667, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 5, hour: 7, minute: 43, second: 12, millisecond: 253, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 6, hour: 4, minute: 32, second: 32, millisecond: 498, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 12, hour: 2, minute: 14, second: 56, millisecond: 304, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 1, hour: 4, minute: 53, second: 30, millisecond: 548, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 8, hour: 7, minute: 47, second: 58, millisecond: 88, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 6, hour: 5, minute: 41, second: 39, millisecond: 448, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 4, hour: 8, minute: 32, second: 33, millisecond: 11, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 7, hour: 13, minute: 50, second: 41, millisecond: 27, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 9, hour: 9, minute: 27, second: 56, millisecond: 159, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 5, hour: 13, minute: 56, second: 20, millisecond: 429, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 3, hour: 8, minute: 53, second: 34, millisecond: 440, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 19, hour: 16, minute: 4, second: 16, millisecond: 13, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 3, hour: 20, minute: 43, second: 26, millisecond: 379, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 8, hour: 12, minute: 58, second: 30, millisecond: 116, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 6, hour: 11, minute: 9, second: 18, millisecond: 833, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 3, minute: 16, second: 16, millisecond: 34, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 3, hour: 20, minute: 34, second: 30, millisecond: 941, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 1, hour: 1, minute: 42, second: 40, millisecond: 268, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 7, hour: 10, minute: 46, second: 28, millisecond: 704, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 17, minute: 54, second: 8, millisecond: 786, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 16, hour: 18, minute: 24, second: 34, millisecond: 813, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 16, hour: 14, minute: 52, second: 31, millisecond: 257, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 13, hour: 1, minute: 43, second: 16, millisecond: 920, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 3, hour: 19, minute: 29, second: 56, millisecond: 264, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 12, hour: 6, minute: 16, second: 55, millisecond: 531, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 9, hour: 18, minute: 39, second: 25, millisecond: 710, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 19, hour: 15, minute: 51, second: 37, millisecond: 964, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 7, hour: 3, minute: 45, second: 4, millisecond: 667, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 4, hour: 19, minute: 32, second: 54, millisecond: 680, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 2, hour: 2, minute: 12, second: 54, millisecond: 853, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 18, hour: 7, minute: 44, second: 47, millisecond: 452, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 16, hour: 5, minute: 31, second: 20, millisecond: 539, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 9, hour: 2, minute: 12, second: 20, millisecond: 437, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 12, hour: 16, minute: 10, second: 32, millisecond: 345, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 11, hour: 11, minute: 10, second: 9, millisecond: 419, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 6, hour: 10, minute: 12, second: 45, millisecond: 120, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 4, hour: 18, minute: 17, second: 30, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 12, hour: 15, minute: 14, second: 10, millisecond: 413, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 6, hour: 16, minute: 9, second: 10, millisecond: 523, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 4, minute: 44, second: 42, millisecond: 360, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 8, hour: 10, minute: 33, second: 48, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 40, second: 55, millisecond: 854, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 4, hour: 15, minute: 7, second: 36, millisecond: 265, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 15, hour: 17, minute: 37, second: 44, millisecond: 350, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 7, hour: 7, minute: 25, second: 36, millisecond: 656, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 15, hour: 6, minute: 56, second: 58, millisecond: 891, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 7, hour: 9, minute: 50, second: 55, millisecond: 633, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 14, hour: 7, minute: 38, second: 22, millisecond: 561, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 4, hour: 4, minute: 1, second: 4, millisecond: 267, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 12, hour: 14, minute: 6, second: 57, millisecond: 657, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 7, hour: 16, minute: 28, second: 51, millisecond: 318, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 4, hour: 19, minute: 5, second: 23, millisecond: 65, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 5, hour: 15, minute: 4, second: 56, millisecond: 480, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 7, hour: 3, minute: 3, second: 31, millisecond: 203, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 8, hour: 18, minute: 9, second: 55, millisecond: 605, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 1, minute: 37, second: 16, millisecond: 404, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 10, hour: 12, minute: 23, second: 11, millisecond: 803, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 11, hour: 1, minute: 5, second: 29, millisecond: 773, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 9, minute: 14, second: 57, millisecond: 911, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 16, hour: 9, minute: 28, second: 55, millisecond: 325, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 9, hour: 18, minute: 21, second: 27, millisecond: 621, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 17, hour: 17, minute: 18, second: 45, millisecond: 216, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 12, hour: 12, minute: 38, second: 24, millisecond: 626, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 8, hour: 7, minute: 43, second: 34, millisecond: 991, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 8, hour: 17, minute: 58, second: 34, millisecond: 96, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 13, hour: 9, minute: 57, second: 54, millisecond: 254, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 2, hour: 2, minute: 34, second: 36, millisecond: 45, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 2, hour: 8, minute: 52, second: 19, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 17, hour: 11, minute: 18, second: 46, millisecond: 7, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


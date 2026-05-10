

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
    Id = 8,
    Value = new DateTime(year: 2004, month: 10, day: 15, hour: 13, minute: 15, second: 47, millisecond: 233, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1997, month: 10, day: 1, hour: 19, minute: 28, second: 19, millisecond: 569, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 12,
    Value = new DateTime(year: 1932, month: 10, day: 11, hour: 2, minute: 22, second: 38, millisecond: 939, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 9,
    Value = new DateTime(year: 1958, month: 10, day: 4, hour: 4, minute: 40, second: 42, millisecond: 917, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1927, month: 10, day: 6, hour: 4, minute: 43, second: 33, millisecond: 364, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 13,
    Value = new DateTime(year: 1991, month: 10, day: 2, hour: 13, minute: 39, second: 55, millisecond: 536, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1980, month: 10, day: 8, hour: 11, minute: 41, second: 45, millisecond: 251, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 16,
    Value = new DateTime(year: 1980, month: 10, day: 5, hour: 15, minute: 32, second: 32, millisecond: 785, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 14,
    Value = new DateTime(year: 2011, month: 10, day: 12, hour: 9, minute: 34, second: 13, millisecond: 929, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1954, month: 10, day: 19, hour: 11, minute: 19, second: 19, millisecond: 530, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 22,
    Value = new DateTime(year: 2017, month: 10, day: 4, hour: 2, minute: 23, second: 1, millisecond: 883, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 17, hour: 22, minute: 8, second: 44, millisecond: 422, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 25,
    Value = new DateTime(year: 1952, month: 10, day: 4, hour: 22, minute: 8, second: 55, millisecond: 810, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 23,
    Value = new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 5, second: 7, millisecond: 360, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2002, month: 10, day: 7, hour: 7, minute: 58, second: 26, millisecond: 514, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 30,
    Value = new DateTime(year: 1929, month: 10, day: 17, hour: 12, minute: 14, second: 11, millisecond: 114, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2004, month: 10, day: 11, hour: 15, minute: 46, second: 10, millisecond: 276, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 31,
    Value = new DateTime(year: 1965, month: 10, day: 7, hour: 18, minute: 55, second: 9, millisecond: 335, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 31,
    Value = new DateTime(year: 1981, month: 10, day: 18, hour: 8, minute: 11, second: 39, millisecond: 725, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 33,
    Value = new DateTime(year: 1976, month: 10, day: 11, hour: 8, minute: 24, second: 41, millisecond: 660, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 39,
    Value = new DateTime(year: 1933, month: 10, day: 17, hour: 15, minute: 44, second: 52, millisecond: 394, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 37,
    Value = new DateTime(year: 2016, month: 10, day: 6, hour: 8, minute: 48, second: 31, millisecond: 136, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1985, month: 10, day: 3, hour: 3, minute: 32, second: 39, millisecond: 723, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1954, month: 10, day: 15, hour: 22, minute: 30, second: 56, millisecond: 434, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 41,
    Value = new DateTime(year: 1923, month: 10, day: 5, hour: 14, minute: 57, second: 36, millisecond: 66, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2006, month: 10, day: 16, hour: 18, minute: 5, second: 43, millisecond: 660, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 44,
    Value = new DateTime(year: 1967, month: 10, day: 1, hour: 17, minute: 21, second: 15, millisecond: 969, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 41,
    Value = new DateTime(year: 1936, month: 10, day: 4, hour: 2, minute: 34, second: 43, millisecond: 616, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1997, month: 10, day: 6, hour: 5, minute: 33, second: 56, millisecond: 98, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 49,
    Value = new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 37, second: 10, millisecond: 658, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1988, month: 10, day: 12, hour: 21, minute: 56, second: 53, millisecond: 252, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 50,
    Value = new DateTime(year: 1942, month: 10, day: 2, hour: 4, minute: 7, second: 13, millisecond: 474, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 44,
    Value = new DateTime(year: 2007, month: 10, day: 19, hour: 11, minute: 45, second: 23, millisecond: 55, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1973, month: 10, day: 16, hour: 22, minute: 50, second: 32, millisecond: 169, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 56,
    Value = new DateTime(year: 1938, month: 10, day: 8, hour: 10, minute: 52, second: 36, millisecond: 755, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 41, second: 52, millisecond: 64, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 58,
    Value = new DateTime(year: 1961, month: 10, day: 17, hour: 14, minute: 17, second: 12, millisecond: 741, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 47,
    Value = new DateTime(year: 1921, month: 10, day: 11, hour: 6, minute: 12, second: 25, millisecond: 555, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1964, month: 10, day: 6, hour: 9, minute: 8, second: 38, millisecond: 366, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 60,
    Value = new DateTime(year: 2001, month: 10, day: 10, hour: 19, minute: 19, second: 15, millisecond: 712, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 62,
    Value = new DateTime(year: 1974, month: 10, day: 4, hour: 21, minute: 39, second: 23, millisecond: 732, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 52,
    Value = new DateTime(year: 1989, month: 10, day: 17, hour: 13, minute: 53, second: 55, millisecond: 852, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1981, month: 10, day: 15, hour: 21, minute: 52, second: 7, millisecond: 486, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1982, month: 10, day: 9, hour: 20, minute: 36, second: 18, millisecond: 784, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 64,
    Value = new DateTime(year: 1933, month: 10, day: 18, hour: 16, minute: 35, second: 40, millisecond: 287, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1991, month: 10, day: 16, hour: 9, minute: 17, second: 22, millisecond: 202, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 70,
    Value = new DateTime(year: 1971, month: 10, day: 11, hour: 19, minute: 15, second: 4, millisecond: 68, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 57,
    Value = new DateTime(year: 1983, month: 10, day: 13, hour: 18, minute: 7, second: 49, millisecond: 110, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1989, month: 10, day: 17, hour: 21, minute: 14, second: 1, millisecond: 453, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 77,
    Value = new DateTime(year: 1968, month: 10, day: 3, hour: 22, minute: 5, second: 11, millisecond: 352, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 81,
    Value = new DateTime(year: 1922, month: 10, day: 19, hour: 21, minute: 20, second: 20, millisecond: 841, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 61,
    Value = new DateTime(year: 1917, month: 10, day: 5, hour: 15, minute: 34, second: 50, millisecond: 373, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 84,
    Value = new DateTime(year: 2009, month: 10, day: 19, hour: 12, minute: 55, second: 30, millisecond: 195, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 12, hour: 2, minute: 42, second: 36, millisecond: 355, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 91,
    Value = new DateTime(year: 1938, month: 10, day: 2, hour: 18, minute: 6, second: 23, millisecond: 700, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 63,
    Value = new DateTime(year: 1979, month: 10, day: 8, hour: 4, minute: 12, second: 13, millisecond: 20, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2003, month: 10, day: 14, hour: 20, minute: 54, second: 12, millisecond: 771, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 99,
    Value = new DateTime(year: 2006, month: 10, day: 18, hour: 11, minute: 16, second: 57, millisecond: 348, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 108,
    Value = new DateTime(year: 1957, month: 10, day: 6, hour: 3, minute: 17, second: 5, millisecond: 588, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 72,
    Value = new DateTime(year: 1978, month: 10, day: 16, hour: 21, minute: 3, second: 16, millisecond: 564, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 114,
    Value = new DateTime(year: 1918, month: 10, day: 11, hour: 7, minute: 3, second: 1, millisecond: 166, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1971, month: 10, day: 3, hour: 11, minute: 38, second: 1, millisecond: 357, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 115,
    Value = new DateTime(year: 1970, month: 10, day: 14, hour: 15, minute: 21, second: 16, millisecond: 344, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 79,
    Value = new DateTime(year: 1985, month: 10, day: 8, hour: 21, minute: 20, second: 29, millisecond: 271, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1943, month: 10, day: 15, hour: 3, minute: 15, second: 3, millisecond: 605, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 120,
    Value = new DateTime(year: 1964, month: 10, day: 18, hour: 15, minute: 1, second: 6, millisecond: 350, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1917, month: 10, day: 12, hour: 3, minute: 6, second: 11, millisecond: 944, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 126,
    Value = new DateTime(year: 1945, month: 10, day: 13, hour: 16, minute: 25, second: 41, millisecond: 619, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 80,
    Value = new DateTime(year: 1993, month: 10, day: 2, hour: 10, minute: 4, second: 38, millisecond: 947, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1935, month: 10, day: 19, hour: 7, minute: 18, second: 7, millisecond: 842, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 131,
    Value = new DateTime(year: 1938, month: 10, day: 1, hour: 5, minute: 42, second: 15, millisecond: 173, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 135,
    Value = new DateTime(year: 1954, month: 10, day: 16, hour: 22, minute: 51, second: 31, millisecond: 243, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 83,
    Value = new DateTime(year: 1993, month: 10, day: 5, hour: 5, minute: 6, second: 17, millisecond: 383, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2001, month: 10, day: 5, hour: 17, minute: 17, second: 29, millisecond: 371, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime0M
{
    Id = 138,
    Value = new DateTime(year: 1920, month: 10, day: 12, hour: 18, minute: 2, second: 22, millisecond: 452, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2018, month: 10, day: 4, hour: 15, minute: 7, second: 37, millisecond: 275, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 141,
    Value = new DateTime(year: 1928, month: 10, day: 1, hour: 7, minute: 45, second: 6, millisecond: 28, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime0MI
{
    Id = 88,
    Value = new DateTime(year: 1937, month: 10, day: 13, hour: 19, minute: 17, second: 41, millisecond: 520, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2013, month: 10, day: 15, hour: 4, minute: 13, second: 8, millisecond: 138, kind: DateTimeKind.Local),
},
            new DateTimedatetime0M
{
    Id = 150,
    Value = new DateTime(year: 2002, month: 10, day: 11, hour: 12, minute: 4, second: 35, millisecond: 872, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1988, month: 10, day: 16, hour: 11, minute: 56, second: 49, millisecond: 482, kind: DateTimeKind.Local),
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
            queryMapTypes: [typeof(FlatDateTimedatetime0M), typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                await((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                ((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
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
                var models = ((IDateTimeSingleTypedatetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M), typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                await((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                ((IDateTimeSingleTypedatetime)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((IDateTimeSingleTypedatetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime0M), typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                await((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
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
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
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
FROM gedaqtests.datetimedatetime0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[13],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[34], false);
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
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
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
FROM gedaqtests.datetimedatetime0m m
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[13],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[14],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[9],_testData[34], false);
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
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DateTimedatetime0M.AssertModel(models[0],_testData[16], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[17], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[18], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[19], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[20], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[21], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[13],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[14],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[15],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[16],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[17],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimedatetime0M.AssertModel(models[0],_testData[20], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[21], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[13],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[14],_testData[34], false);
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
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateTimedatetime0M.AssertModel(models[0],_testData[4], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[5], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[6], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[7], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[8], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[9], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[10], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[11], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[12], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[13], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[14], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[15], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[16], false);
                        DateTimedatetime0M.AssertModel(models[13],_testData[17], false);
                        DateTimedatetime0M.AssertModel(models[14],_testData[18], false);
                        DateTimedatetime0M.AssertModel(models[15],_testData[19], false);
                        DateTimedatetime0M.AssertModel(models[16],_testData[20], false);
                        DateTimedatetime0M.AssertModel(models[17],_testData[21], false);
                        DateTimedatetime0M.AssertModel(models[18],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[19],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[20],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[21],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[22],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[23],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[24],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[25],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[26],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[27],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[28],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[29],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DateTimedatetime0M.AssertModel(models[0],_testData[7], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[8], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[9], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[10], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[11], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[12], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[13], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[14], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[15], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[16], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[17], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[18], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[19], false);
                        DateTimedatetime0M.AssertModel(models[13],_testData[20], false);
                        DateTimedatetime0M.AssertModel(models[14],_testData[21], false);
                        DateTimedatetime0M.AssertModel(models[15],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[16],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[17],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[18],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[19],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[20],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[21],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[22],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[23],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[24],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[25],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[26],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M), typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                await((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime0M>();
                var models2 = new List<FlatDateTimedatetime0M>();
                ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var firstItems2 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime0M)],
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[24],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                await ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[23],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.datetimedatetime0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[13], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[14], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[15], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[16], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[13],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[14],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[15],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[16],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[17],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[18],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[19],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[20],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimedatetime0M.AssertModel(models[0],_testData[17], false);
                        FlatDateTimedatetime0M.AssertModel(models[1],_testData[18], false);
                        FlatDateTimedatetime0M.AssertModel(models[2],_testData[19], false);
                        FlatDateTimedatetime0M.AssertModel(models[3],_testData[20], false);
                        FlatDateTimedatetime0M.AssertModel(models[4],_testData[21], false);
                        FlatDateTimedatetime0M.AssertModel(models[5],_testData[22], false);
                        FlatDateTimedatetime0M.AssertModel(models[6],_testData[23], false);
                        FlatDateTimedatetime0M.AssertModel(models[7],_testData[24], false);
                        FlatDateTimedatetime0M.AssertModel(models[8],_testData[25], false);
                        FlatDateTimedatetime0M.AssertModel(models[9],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(models[10],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(models[11],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(models[12],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(models[13],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(models[14],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(models[15],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(models[16],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(models[17],_testData[34], false);
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
FROM gedaqtests.datetimedatetime0m m
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
FROM gedaqtests.datetimedatetime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems1 = new List<FlatDateTimedatetime0M>();
                var secondItems2 = new List<FlatDateTimedatetime0M>();
                 ((IDateTimeSingleTypedatetime)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimedatetime0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimedatetime0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDateTimedatetime0M.AssertModel(secondItems2[8],_testData[34], false);
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
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateTimedatetime0M.AssertModel(models[0],_testData[4], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[5], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[6], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[7], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[8], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[9], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[10], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[11], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[12], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[13], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[14], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[15], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[16], false);
                        DateTimedatetime0M.AssertModel(models[13],_testData[17], false);
                        DateTimedatetime0M.AssertModel(models[14],_testData[18], false);
                        DateTimedatetime0M.AssertModel(models[15],_testData[19], false);
                        DateTimedatetime0M.AssertModel(models[16],_testData[20], false);
                        DateTimedatetime0M.AssertModel(models[17],_testData[21], false);
                        DateTimedatetime0M.AssertModel(models[18],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[19],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[20],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[21],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[22],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[23],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[24],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[25],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[26],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[27],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[28],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[29],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DateTimedatetime0M.AssertModel(models[0],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[34], false);
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
                    DateTimedatetime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime)this).DbConnectionSTSelectModelBatch(connection, 108, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DateTimedatetime0M.AssertModel(models[0],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimedatetime0M.AssertModel(models[0],_testData[22], false);
                        DateTimedatetime0M.AssertModel(models[1],_testData[23], false);
                        DateTimedatetime0M.AssertModel(models[2],_testData[24], false);
                        DateTimedatetime0M.AssertModel(models[3],_testData[25], false);
                        DateTimedatetime0M.AssertModel(models[4],_testData[26], false);
                        DateTimedatetime0M.AssertModel(models[5],_testData[27], false);
                        DateTimedatetime0M.AssertModel(models[6],_testData[28], false);
                        DateTimedatetime0M.AssertModel(models[7],_testData[29], false);
                        DateTimedatetime0M.AssertModel(models[8],_testData[30], false);
                        DateTimedatetime0M.AssertModel(models[9],_testData[31], false);
                        DateTimedatetime0M.AssertModel(models[10],_testData[32], false);
                        DateTimedatetime0M.AssertModel(models[11],_testData[33], false);
                        DateTimedatetime0M.AssertModel(models[12],_testData[34], false);
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
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models = await ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DateTimedatetime0M.AssertModel(models[0],_testData[8], false);
                DateTimedatetime0M.AssertModel(models[1],_testData[9], false);
                DateTimedatetime0M.AssertModel(models[2],_testData[10], false);
                DateTimedatetime0M.AssertModel(models[3],_testData[11], false);
                DateTimedatetime0M.AssertModel(models[4],_testData[12], false);
                DateTimedatetime0M.AssertModel(models[5],_testData[13], false);
                DateTimedatetime0M.AssertModel(models[6],_testData[14], false);
                DateTimedatetime0M.AssertModel(models[7],_testData[15], false);
                DateTimedatetime0M.AssertModel(models[8],_testData[16], false);
                DateTimedatetime0M.AssertModel(models[9],_testData[17], false);
                DateTimedatetime0M.AssertModel(models[10],_testData[18], false);
                DateTimedatetime0M.AssertModel(models[11],_testData[19], false);
                DateTimedatetime0M.AssertModel(models[12],_testData[20], false);
                DateTimedatetime0M.AssertModel(models[13],_testData[21], false);
                DateTimedatetime0M.AssertModel(models[14],_testData[22], false);
                DateTimedatetime0M.AssertModel(models[15],_testData[23], false);
                DateTimedatetime0M.AssertModel(models[16],_testData[24], false);
                DateTimedatetime0M.AssertModel(models[17],_testData[25], false);
                DateTimedatetime0M.AssertModel(models[18],_testData[26], false);
                DateTimedatetime0M.AssertModel(models[19],_testData[27], false);
                DateTimedatetime0M.AssertModel(models[20],_testData[28], false);
                DateTimedatetime0M.AssertModel(models[21],_testData[29], false);
                DateTimedatetime0M.AssertModel(models[22],_testData[30], false);
                DateTimedatetime0M.AssertModel(models[23],_testData[31], false);
                DateTimedatetime0M.AssertModel(models[24],_testData[32], false);
                DateTimedatetime0M.AssertModel(models[25],_testData[33], false);
                DateTimedatetime0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                DateTimedatetime0M.AssertModel(models[0],_testData[10], false);
                DateTimedatetime0M.AssertModel(models[1],_testData[11], false);
                DateTimedatetime0M.AssertModel(models[2],_testData[12], false);
                DateTimedatetime0M.AssertModel(models[3],_testData[13], false);
                DateTimedatetime0M.AssertModel(models[4],_testData[14], false);
                DateTimedatetime0M.AssertModel(models[5],_testData[15], false);
                DateTimedatetime0M.AssertModel(models[6],_testData[16], false);
                DateTimedatetime0M.AssertModel(models[7],_testData[17], false);
                DateTimedatetime0M.AssertModel(models[8],_testData[18], false);
                DateTimedatetime0M.AssertModel(models[9],_testData[19], false);
                DateTimedatetime0M.AssertModel(models[10],_testData[20], false);
                DateTimedatetime0M.AssertModel(models[11],_testData[21], false);
                DateTimedatetime0M.AssertModel(models[12],_testData[22], false);
                DateTimedatetime0M.AssertModel(models[13],_testData[23], false);
                DateTimedatetime0M.AssertModel(models[14],_testData[24], false);
                DateTimedatetime0M.AssertModel(models[15],_testData[25], false);
                DateTimedatetime0M.AssertModel(models[16],_testData[26], false);
                DateTimedatetime0M.AssertModel(models[17],_testData[27], false);
                DateTimedatetime0M.AssertModel(models[18],_testData[28], false);
                DateTimedatetime0M.AssertModel(models[19],_testData[29], false);
                DateTimedatetime0M.AssertModel(models[20],_testData[30], false);
                DateTimedatetime0M.AssertModel(models[21],_testData[31], false);
                DateTimedatetime0M.AssertModel(models[22],_testData[32], false);
                DateTimedatetime0M.AssertModel(models[23],_testData[33], false);
                DateTimedatetime0M.AssertModel(models[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 15, hour: 13, minute: 15, second: 47, millisecond: 233, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 1, hour: 19, minute: 28, second: 19, millisecond: 569, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 11, hour: 2, minute: 22, second: 38, millisecond: 939, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 4, hour: 4, minute: 40, second: 42, millisecond: 917, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 6, hour: 4, minute: 43, second: 33, millisecond: 364, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 2, hour: 13, minute: 39, second: 55, millisecond: 536, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 11, minute: 41, second: 45, millisecond: 251, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 5, hour: 15, minute: 32, second: 32, millisecond: 785, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 12, hour: 9, minute: 34, second: 13, millisecond: 929, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 19, hour: 11, minute: 19, second: 19, millisecond: 530, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 4, hour: 2, minute: 23, second: 1, millisecond: 883, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 17, hour: 22, minute: 8, second: 44, millisecond: 422, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 4, hour: 22, minute: 8, second: 55, millisecond: 810, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 5, second: 7, millisecond: 360, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 7, hour: 7, minute: 58, second: 26, millisecond: 514, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 17, hour: 12, minute: 14, second: 11, millisecond: 114, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 11, hour: 15, minute: 46, second: 10, millisecond: 276, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 7, hour: 18, minute: 55, second: 9, millisecond: 335, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 18, hour: 8, minute: 11, second: 39, millisecond: 725, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 11, hour: 8, minute: 24, second: 41, millisecond: 660, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 17, hour: 15, minute: 44, second: 52, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 6, hour: 8, minute: 48, second: 31, millisecond: 136, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 3, hour: 3, minute: 32, second: 39, millisecond: 723, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 15, hour: 22, minute: 30, second: 56, millisecond: 434, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 5, hour: 14, minute: 57, second: 36, millisecond: 66, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 16, hour: 18, minute: 5, second: 43, millisecond: 660, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 1, hour: 17, minute: 21, second: 15, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 4, hour: 2, minute: 34, second: 43, millisecond: 616, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 6, hour: 5, minute: 33, second: 56, millisecond: 98, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 37, second: 10, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 21, minute: 56, second: 53, millisecond: 252, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 2, hour: 4, minute: 7, second: 13, millisecond: 474, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 19, hour: 11, minute: 45, second: 23, millisecond: 55, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 16, hour: 22, minute: 50, second: 32, millisecond: 169, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 8, hour: 10, minute: 52, second: 36, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 41, second: 52, millisecond: 64, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 17, hour: 14, minute: 17, second: 12, millisecond: 741, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 11, hour: 6, minute: 12, second: 25, millisecond: 555, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 6, hour: 9, minute: 8, second: 38, millisecond: 366, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 10, hour: 19, minute: 19, second: 15, millisecond: 712, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 21, minute: 39, second: 23, millisecond: 732, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 17, hour: 13, minute: 53, second: 55, millisecond: 852, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 15, hour: 21, minute: 52, second: 7, millisecond: 486, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 9, hour: 20, minute: 36, second: 18, millisecond: 784, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 18, hour: 16, minute: 35, second: 40, millisecond: 287, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 16, hour: 9, minute: 17, second: 22, millisecond: 202, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 11, hour: 19, minute: 15, second: 4, millisecond: 68, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 13, hour: 18, minute: 7, second: 49, millisecond: 110, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 17, hour: 21, minute: 14, second: 1, millisecond: 453, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 3, hour: 22, minute: 5, second: 11, millisecond: 352, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 21, minute: 20, second: 20, millisecond: 841, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 5, hour: 15, minute: 34, second: 50, millisecond: 373, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 12, minute: 55, second: 30, millisecond: 195, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 12, hour: 2, minute: 42, second: 36, millisecond: 355, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 2, hour: 18, minute: 6, second: 23, millisecond: 700, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 8, hour: 4, minute: 12, second: 13, millisecond: 20, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 14, hour: 20, minute: 54, second: 12, millisecond: 771, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 18, hour: 11, minute: 16, second: 57, millisecond: 348, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 6, hour: 3, minute: 17, second: 5, millisecond: 588, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 16, hour: 21, minute: 3, second: 16, millisecond: 564, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 11, hour: 7, minute: 3, second: 1, millisecond: 166, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 3, hour: 11, minute: 38, second: 1, millisecond: 357, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 14, hour: 15, minute: 21, second: 16, millisecond: 344, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 8, hour: 21, minute: 20, second: 29, millisecond: 271, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 15, hour: 3, minute: 15, second: 3, millisecond: 605, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 18, hour: 15, minute: 1, second: 6, millisecond: 350, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 12, hour: 3, minute: 6, second: 11, millisecond: 944, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 13, hour: 16, minute: 25, second: 41, millisecond: 619, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 2, hour: 10, minute: 4, second: 38, millisecond: 947, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 19, hour: 7, minute: 18, second: 7, millisecond: 842, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 1, hour: 5, minute: 42, second: 15, millisecond: 173, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 16, hour: 22, minute: 51, second: 31, millisecond: 243, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 5, hour: 5, minute: 6, second: 17, millisecond: 383, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 5, hour: 17, minute: 17, second: 29, millisecond: 371, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 12, hour: 18, minute: 2, second: 22, millisecond: 452, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 4, hour: 15, minute: 7, second: 37, millisecond: 275, kind: DateTimeKind.Local))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 1, hour: 7, minute: 45, second: 6, millisecond: 28, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 13, hour: 19, minute: 17, second: 41, millisecond: 520, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 15, hour: 4, minute: 13, second: 8, millisecond: 138, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 11, hour: 12, minute: 4, second: 35, millisecond: 872, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 16, hour: 11, minute: 56, second: 49, millisecond: 482, kind: DateTimeKind.Local))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 15, hour: 13, minute: 15, second: 47, millisecond: 233, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 1, hour: 19, minute: 28, second: 19, millisecond: 569, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 11, hour: 2, minute: 22, second: 38, millisecond: 939, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 4, hour: 4, minute: 40, second: 42, millisecond: 917, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 6, hour: 4, minute: 43, second: 33, millisecond: 364, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 2, hour: 13, minute: 39, second: 55, millisecond: 536, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 8, hour: 11, minute: 41, second: 45, millisecond: 251, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 5, hour: 15, minute: 32, second: 32, millisecond: 785, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 12, hour: 9, minute: 34, second: 13, millisecond: 929, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 19, hour: 11, minute: 19, second: 19, millisecond: 530, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 4, hour: 2, minute: 23, second: 1, millisecond: 883, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 17, hour: 22, minute: 8, second: 44, millisecond: 422, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 4, hour: 22, minute: 8, second: 55, millisecond: 810, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 5, second: 7, millisecond: 360, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 7, hour: 7, minute: 58, second: 26, millisecond: 514, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 17, hour: 12, minute: 14, second: 11, millisecond: 114, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 11, hour: 15, minute: 46, second: 10, millisecond: 276, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 7, hour: 18, minute: 55, second: 9, millisecond: 335, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 18, hour: 8, minute: 11, second: 39, millisecond: 725, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 11, hour: 8, minute: 24, second: 41, millisecond: 660, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 17, hour: 15, minute: 44, second: 52, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 6, hour: 8, minute: 48, second: 31, millisecond: 136, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 3, hour: 3, minute: 32, second: 39, millisecond: 723, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 15, hour: 22, minute: 30, second: 56, millisecond: 434, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 5, hour: 14, minute: 57, second: 36, millisecond: 66, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 16, hour: 18, minute: 5, second: 43, millisecond: 660, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 1, hour: 17, minute: 21, second: 15, millisecond: 969, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 4, hour: 2, minute: 34, second: 43, millisecond: 616, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 6, hour: 5, minute: 33, second: 56, millisecond: 98, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 7, hour: 13, minute: 37, second: 10, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 21, minute: 56, second: 53, millisecond: 252, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 2, hour: 4, minute: 7, second: 13, millisecond: 474, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 19, hour: 11, minute: 45, second: 23, millisecond: 55, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 16, hour: 22, minute: 50, second: 32, millisecond: 169, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 8, hour: 10, minute: 52, second: 36, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 41, second: 52, millisecond: 64, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 17, hour: 14, minute: 17, second: 12, millisecond: 741, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 11, hour: 6, minute: 12, second: 25, millisecond: 555, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 6, hour: 9, minute: 8, second: 38, millisecond: 366, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 10, hour: 19, minute: 19, second: 15, millisecond: 712, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 21, minute: 39, second: 23, millisecond: 732, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 17, hour: 13, minute: 53, second: 55, millisecond: 852, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 15, hour: 21, minute: 52, second: 7, millisecond: 486, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 9, hour: 20, minute: 36, second: 18, millisecond: 784, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 18, hour: 16, minute: 35, second: 40, millisecond: 287, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 16, hour: 9, minute: 17, second: 22, millisecond: 202, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 11, hour: 19, minute: 15, second: 4, millisecond: 68, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 13, hour: 18, minute: 7, second: 49, millisecond: 110, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 17, hour: 21, minute: 14, second: 1, millisecond: 453, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 3, hour: 22, minute: 5, second: 11, millisecond: 352, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 19, hour: 21, minute: 20, second: 20, millisecond: 841, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 5, hour: 15, minute: 34, second: 50, millisecond: 373, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 12, minute: 55, second: 30, millisecond: 195, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 12, hour: 2, minute: 42, second: 36, millisecond: 355, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 2, hour: 18, minute: 6, second: 23, millisecond: 700, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 8, hour: 4, minute: 12, second: 13, millisecond: 20, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 14, hour: 20, minute: 54, second: 12, millisecond: 771, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 18, hour: 11, minute: 16, second: 57, millisecond: 348, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 6, hour: 3, minute: 17, second: 5, millisecond: 588, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 16, hour: 21, minute: 3, second: 16, millisecond: 564, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 11, hour: 7, minute: 3, second: 1, millisecond: 166, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 3, hour: 11, minute: 38, second: 1, millisecond: 357, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 14, hour: 15, minute: 21, second: 16, millisecond: 344, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 8, hour: 21, minute: 20, second: 29, millisecond: 271, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 15, hour: 3, minute: 15, second: 3, millisecond: 605, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 18, hour: 15, minute: 1, second: 6, millisecond: 350, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 12, hour: 3, minute: 6, second: 11, millisecond: 944, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 13, hour: 16, minute: 25, second: 41, millisecond: 619, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 2, hour: 10, minute: 4, second: 38, millisecond: 947, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 19, hour: 7, minute: 18, second: 7, millisecond: 842, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 1, hour: 5, minute: 42, second: 15, millisecond: 173, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 16, hour: 22, minute: 51, second: 31, millisecond: 243, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 5, hour: 5, minute: 6, second: 17, millisecond: 383, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 5, hour: 17, minute: 17, second: 29, millisecond: 371, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 12, hour: 18, minute: 2, second: 22, millisecond: 452, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 4, hour: 15, minute: 7, second: 37, millisecond: 275, kind: DateTimeKind.Local))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 1, hour: 7, minute: 45, second: 6, millisecond: 28, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 13, hour: 19, minute: 17, second: 41, millisecond: 520, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 15, hour: 4, minute: 13, second: 8, millisecond: 138, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 11, hour: 12, minute: 4, second: 35, millisecond: 872, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 16, hour: 11, minute: 56, second: 49, millisecond: 482, kind: DateTimeKind.Local))));

            }
        }

#endregion

    }
}


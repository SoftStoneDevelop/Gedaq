

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDateTimeSingleTypedatetime2
    {
    }
    
    internal partial class DateTimeSingleTypedatetime2 : IDateTimeSingleTypedatetime2
    {


#region TestData

        private readonly DateTimedatetime2E0M[] _testData = new DateTimedatetime2E0M[]
        {
            new DateTimedatetime2E0M
{
    Id = 3,
    Value = new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 1, second: 26, millisecond: 251, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 10,
    Value = new DateTime(year: 1946, month: 10, day: 17, hour: 2, minute: 3, second: 41, millisecond: 973, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 6,
    Value = new DateTime(year: 1939, month: 10, day: 10, hour: 10, minute: 37, second: 10, millisecond: 925, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1976, month: 10, day: 4, hour: 13, minute: 10, second: 43, millisecond: 942, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 19,
    Value = new DateTime(year: 1955, month: 10, day: 17, hour: 8, minute: 28, second: 2, millisecond: 363, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 22,
    Value = new DateTime(year: 1940, month: 10, day: 10, hour: 9, minute: 10, second: 36, millisecond: 994, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 15,
    Value = new DateTime(year: 2017, month: 10, day: 6, hour: 1, minute: 46, second: 25, millisecond: 680, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1972, month: 10, day: 1, hour: 20, minute: 52, second: 16, millisecond: 448, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 23,
    Value = new DateTime(year: 1917, month: 10, day: 1, hour: 14, minute: 21, second: 1, millisecond: 394, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 29,
    Value = new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 38, second: 36, millisecond: 505, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 24,
    Value = new DateTime(year: 2011, month: 10, day: 6, hour: 2, minute: 55, second: 35, millisecond: 172, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1994, month: 10, day: 17, hour: 8, minute: 13, second: 8, millisecond: 566, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 37,
    Value = new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 41, second: 39, millisecond: 510, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 45, second: 17, millisecond: 834, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 42,
    Value = new DateTime(year: 1961, month: 10, day: 1, hour: 19, minute: 1, second: 12, millisecond: 592, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 27,
    Value = new DateTime(year: 1927, month: 10, day: 6, hour: 3, minute: 24, second: 35, millisecond: 40, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2015, month: 10, day: 12, hour: 22, minute: 36, second: 29, millisecond: 780, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 44,
    Value = new DateTime(year: 1998, month: 10, day: 17, hour: 22, minute: 56, second: 9, millisecond: 318, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 45,
    Value = new DateTime(year: 1982, month: 10, day: 1, hour: 4, minute: 58, second: 5, millisecond: 351, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 31,
    Value = new DateTime(year: 1990, month: 10, day: 5, hour: 22, minute: 34, second: 15, millisecond: 235, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1926, month: 10, day: 13, hour: 8, minute: 1, second: 56, millisecond: 620, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 54,
    Value = new DateTime(year: 1987, month: 10, day: 1, hour: 2, minute: 3, second: 50, millisecond: 111, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 63,
    Value = new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 20, second: 54, millisecond: 921, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 35,
    Value = new DateTime(year: 1981, month: 10, day: 17, hour: 5, minute: 45, second: 56, millisecond: 351, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1941, month: 10, day: 14, hour: 15, minute: 20, second: 12, millisecond: 450, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 71,
    Value = new DateTime(year: 1929, month: 10, day: 1, hour: 2, minute: 57, second: 53, millisecond: 230, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2001, month: 10, day: 17, hour: 17, minute: 17, second: 31, millisecond: 987, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 74,
    Value = new DateTime(year: 1924, month: 10, day: 6, hour: 17, minute: 50, second: 11, millisecond: 513, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 36,
    Value = new DateTime(year: 2016, month: 10, day: 7, hour: 2, minute: 22, second: 26, millisecond: 5, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1941, month: 10, day: 13, hour: 13, minute: 55, second: 23, millisecond: 788, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 82,
    Value = new DateTime(year: 1937, month: 10, day: 7, hour: 20, minute: 44, second: 13, millisecond: 708, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1966, month: 10, day: 13, hour: 5, minute: 14, second: 2, millisecond: 189, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 83,
    Value = new DateTime(year: 2003, month: 10, day: 1, hour: 18, minute: 35, second: 30, millisecond: 182, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 39,
    Value = new DateTime(year: 2017, month: 10, day: 10, hour: 10, minute: 43, second: 2, millisecond: 838, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1922, month: 10, day: 16, hour: 1, minute: 5, second: 58, millisecond: 493, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 88,
    Value = new DateTime(year: 2004, month: 10, day: 10, hour: 15, minute: 26, second: 9, millisecond: 538, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 91,
    Value = new DateTime(year: 1989, month: 10, day: 9, hour: 16, minute: 30, second: 7, millisecond: 830, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 45,
    Value = new DateTime(year: 1957, month: 10, day: 16, hour: 17, minute: 21, second: 18, millisecond: 434, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 27, second: 5, millisecond: 540, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 95,
    Value = new DateTime(year: 1942, month: 10, day: 6, hour: 20, minute: 22, second: 58, millisecond: 39, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1945, month: 10, day: 7, hour: 5, minute: 7, second: 7, millisecond: 960, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 96,
    Value = new DateTime(year: 1935, month: 10, day: 17, hour: 15, minute: 37, second: 26, millisecond: 318, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 49,
    Value = new DateTime(year: 1991, month: 10, day: 7, hour: 8, minute: 44, second: 17, millisecond: 801, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 97,
    Value = new DateTime(year: 2019, month: 10, day: 15, hour: 1, minute: 49, second: 44, millisecond: 717, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 98,
    Value = new DateTime(year: 1926, month: 10, day: 16, hour: 15, minute: 16, second: 16, millisecond: 603, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 55,
    Value = new DateTime(year: 1973, month: 10, day: 18, hour: 19, minute: 28, second: 15, millisecond: 522, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1968, month: 10, day: 1, hour: 3, minute: 22, second: 49, millisecond: 558, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1971, month: 10, day: 5, hour: 9, minute: 17, second: 53, millisecond: 35, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 104,
    Value = new DateTime(year: 1957, month: 10, day: 5, hour: 14, minute: 1, second: 54, millisecond: 716, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1971, month: 10, day: 16, hour: 6, minute: 9, second: 34, millisecond: 610, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 112,
    Value = new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 9, second: 26, millisecond: 255, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 63,
    Value = new DateTime(year: 1953, month: 10, day: 14, hour: 3, minute: 39, second: 8, millisecond: 465, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1944, month: 10, day: 7, hour: 16, minute: 54, second: 49, millisecond: 119, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 119,
    Value = new DateTime(year: 2016, month: 10, day: 5, hour: 2, minute: 5, second: 24, millisecond: 71, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2014, month: 10, day: 1, hour: 11, minute: 31, second: 1, millisecond: 616, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 123,
    Value = new DateTime(year: 2016, month: 10, day: 4, hour: 2, minute: 47, second: 20, millisecond: 658, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 71,
    Value = new DateTime(year: 1969, month: 10, day: 11, hour: 19, minute: 3, second: 28, millisecond: 484, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1974, month: 10, day: 1, hour: 21, minute: 24, second: 18, millisecond: 967, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 127,
    Value = new DateTime(year: 1985, month: 10, day: 13, hour: 17, minute: 28, second: 48, millisecond: 464, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 129,
    Value = new DateTime(year: 1974, month: 10, day: 15, hour: 14, minute: 13, second: 55, millisecond: 23, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 72,
    Value = new DateTime(year: 1923, month: 10, day: 4, hour: 14, minute: 18, second: 30, millisecond: 764, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1995, month: 10, day: 12, hour: 17, minute: 39, second: 13, millisecond: 8, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 134,
    Value = new DateTime(year: 1934, month: 10, day: 5, hour: 8, minute: 46, second: 34, millisecond: 760, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1950, month: 10, day: 3, hour: 14, minute: 45, second: 11, millisecond: 934, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 137,
    Value = new DateTime(year: 1964, month: 10, day: 15, hour: 11, minute: 43, second: 50, millisecond: 761, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 81,
    Value = new DateTime(year: 1919, month: 10, day: 14, hour: 10, minute: 47, second: 33, millisecond: 133, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1937, month: 10, day: 11, hour: 13, minute: 27, second: 20, millisecond: 452, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 144,
    Value = new DateTime(year: 1990, month: 10, day: 15, hour: 20, minute: 13, second: 23, millisecond: 491, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 146,
    Value = new DateTime(year: 1964, month: 10, day: 1, hour: 21, minute: 51, second: 28, millisecond: 182, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 86,
    Value = new DateTime(year: 2015, month: 10, day: 6, hour: 8, minute: 16, second: 2, millisecond: 3, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2005, month: 10, day: 7, hour: 21, minute: 23, second: 48, millisecond: 221, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1931, month: 10, day: 1, hour: 14, minute: 17, second: 55, millisecond: 636, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 153,
    Value = new DateTime(year: 1999, month: 10, day: 8, hour: 22, minute: 36, second: 51, millisecond: 668, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 159,
    Value = new DateTime(year: 1991, month: 10, day: 12, hour: 6, minute: 19, second: 28, millisecond: 344, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 90,
    Value = new DateTime(year: 2005, month: 10, day: 16, hour: 5, minute: 30, second: 43, millisecond: 68, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1974, month: 10, day: 6, hour: 21, minute: 1, second: 5, millisecond: 393, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 161,
    Value = new DateTime(year: 1930, month: 10, day: 15, hour: 20, minute: 35, second: 17, millisecond: 758, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime2e0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(33)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(33))
            ]
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime2e0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)26),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)26, 
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime2e0m(
	id,
    value,
    nullablevalue,
    datetimedatetime2e0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime2e0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(33)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(33),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime2e0mi_id", 
                methodParametrName: "datetimedatetime2e0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime2e0m(
	id,
    value,
    nullablevalue,
    datetimedatetime2e0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime2e0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)26),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)26,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime2e0mi_id", 
                methodParametrName: "datetimedatetime2e0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M), typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                await((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                ((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.datetimedatetime2e0m m
LEFT JOIN dbo.datetimedatetime2e0mi mi ON mi.id = m.datetimedatetime2e0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M), typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                await((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                ((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.datetimedatetime2e0m m
LEFT JOIN dbo.datetimedatetime2e0mi mi ON mi.id = m.datetimedatetime2e0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateTimeSingleTypedatetime2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateTimeSingleTypedatetime2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M), typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                await((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 137;
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[23],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[24],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[25],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[26],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[27],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[23],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[24],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[25],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[26],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[27],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
LEFT JOIN dbo.datetimedatetime2e0mi mi ON mi.id = m.datetimedatetime2e0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
                var models = await((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[2], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[3], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[4], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[5], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[6], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[7], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[8], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[9], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[10], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[11], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[12], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[13], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[14], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[15], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[16], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[17], false);
                        DateTimedatetime2E0M.AssertModel(models[16],_testData[18], false);
                        DateTimedatetime2E0M.AssertModel(models[17],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[18],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[19],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[20],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[21],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[22],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[23],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[24],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[25],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[26],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[27],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[28],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[29],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[30],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[31],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[15], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[16], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[17], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[18], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[16],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[17],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[18],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M), typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                await((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 153, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 123, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime2E0M>();
                var models2 = new List<FlatDateTimedatetime2E0M>();
                ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateTimedatetime2E0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 45, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var firstItems2 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[21],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[22],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[23],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[24],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[25],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[26],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[27],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[28],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
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
FROM dbo.datetimedatetime2e0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems1 = new List<FlatDateTimedatetime2E0M>();
                var secondItems2 = new List<FlatDateTimedatetime2E0M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
LEFT JOIN dbo.datetimedatetime2e0mi mi ON mi.id = m.datetimedatetime2e0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimedatetime2E0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
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
                var models = await((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatchAsync(connection, 137, 3))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[1], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[2], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[3], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[4], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[5], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[6], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[7], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[8], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[9], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[10], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[11], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[12], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[13], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[14], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[15], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[16], false);
                        DateTimedatetime2E0M.AssertModel(models[16],_testData[17], false);
                        DateTimedatetime2E0M.AssertModel(models[17],_testData[18], false);
                        DateTimedatetime2E0M.AssertModel(models[18],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[19],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[20],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[21],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[22],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[23],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[24],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[25],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[26],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[27],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[28],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[29],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[30],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[31],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[32],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateTimedatetime2E0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatch(connection, 123, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                DateTimedatetime2E0M.AssertModel(models[0],_testData[26], false);
                DateTimedatetime2E0M.AssertModel(models[1],_testData[27], false);
                DateTimedatetime2E0M.AssertModel(models[2],_testData[28], false);
                DateTimedatetime2E0M.AssertModel(models[3],_testData[29], false);
                DateTimedatetime2E0M.AssertModel(models[4],_testData[30], false);
                DateTimedatetime2E0M.AssertModel(models[5],_testData[31], false);
                DateTimedatetime2E0M.AssertModel(models[6],_testData[32], false);
                DateTimedatetime2E0M.AssertModel(models[7],_testData[33], false);
                DateTimedatetime2E0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DateTimedatetime2E0M.AssertModel(models[0],_testData[12], false);
                DateTimedatetime2E0M.AssertModel(models[1],_testData[13], false);
                DateTimedatetime2E0M.AssertModel(models[2],_testData[14], false);
                DateTimedatetime2E0M.AssertModel(models[3],_testData[15], false);
                DateTimedatetime2E0M.AssertModel(models[4],_testData[16], false);
                DateTimedatetime2E0M.AssertModel(models[5],_testData[17], false);
                DateTimedatetime2E0M.AssertModel(models[6],_testData[18], false);
                DateTimedatetime2E0M.AssertModel(models[7],_testData[19], false);
                DateTimedatetime2E0M.AssertModel(models[8],_testData[20], false);
                DateTimedatetime2E0M.AssertModel(models[9],_testData[21], false);
                DateTimedatetime2E0M.AssertModel(models[10],_testData[22], false);
                DateTimedatetime2E0M.AssertModel(models[11],_testData[23], false);
                DateTimedatetime2E0M.AssertModel(models[12],_testData[24], false);
                DateTimedatetime2E0M.AssertModel(models[13],_testData[25], false);
                DateTimedatetime2E0M.AssertModel(models[14],_testData[26], false);
                DateTimedatetime2E0M.AssertModel(models[15],_testData[27], false);
                DateTimedatetime2E0M.AssertModel(models[16],_testData[28], false);
                DateTimedatetime2E0M.AssertModel(models[17],_testData[29], false);
                DateTimedatetime2E0M.AssertModel(models[18],_testData[30], false);
                DateTimedatetime2E0M.AssertModel(models[19],_testData[31], false);
                DateTimedatetime2E0M.AssertModel(models[20],_testData[32], false);
                DateTimedatetime2E0M.AssertModel(models[21],_testData[33], false);
                DateTimedatetime2E0M.AssertModel(models[22],_testData[34], false);
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
FROM dbo.datetimedatetime2e0m m
LEFT JOIN dbo.datetimedatetime2e0mi mi ON mi.id = m.datetimedatetime2e0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 1, second: 26, millisecond: 251, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 17, hour: 2, minute: 3, second: 41, millisecond: 973, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 10, hour: 10, minute: 37, second: 10, millisecond: 925, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 4, hour: 13, minute: 10, second: 43, millisecond: 942, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 17, hour: 8, minute: 28, second: 2, millisecond: 363, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 9, minute: 10, second: 36, millisecond: 994, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 1, minute: 46, second: 25, millisecond: 680, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 20, minute: 52, second: 16, millisecond: 448, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 1, hour: 14, minute: 21, second: 1, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 38, second: 36, millisecond: 505, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 6, hour: 2, minute: 55, second: 35, millisecond: 172, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 17, hour: 8, minute: 13, second: 8, millisecond: 566, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 41, second: 39, millisecond: 510, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 45, second: 17, millisecond: 834, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 1, hour: 19, minute: 1, second: 12, millisecond: 592, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 6, hour: 3, minute: 24, second: 35, millisecond: 40, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 12, hour: 22, minute: 36, second: 29, millisecond: 780, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 17, hour: 22, minute: 56, second: 9, millisecond: 318, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 1, hour: 4, minute: 58, second: 5, millisecond: 351, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 5, hour: 22, minute: 34, second: 15, millisecond: 235, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 13, hour: 8, minute: 1, second: 56, millisecond: 620, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 1, hour: 2, minute: 3, second: 50, millisecond: 111, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 20, second: 54, millisecond: 921, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 17, hour: 5, minute: 45, second: 56, millisecond: 351, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 14, hour: 15, minute: 20, second: 12, millisecond: 450, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 1, hour: 2, minute: 57, second: 53, millisecond: 230, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 17, hour: 17, minute: 17, second: 31, millisecond: 987, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 6, hour: 17, minute: 50, second: 11, millisecond: 513, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 7, hour: 2, minute: 22, second: 26, millisecond: 5, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 13, hour: 13, minute: 55, second: 23, millisecond: 788, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 7, hour: 20, minute: 44, second: 13, millisecond: 708, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 13, hour: 5, minute: 14, second: 2, millisecond: 189, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 1, hour: 18, minute: 35, second: 30, millisecond: 182, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 10, hour: 10, minute: 43, second: 2, millisecond: 838, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 16, hour: 1, minute: 5, second: 58, millisecond: 493, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 10, hour: 15, minute: 26, second: 9, millisecond: 538, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 9, hour: 16, minute: 30, second: 7, millisecond: 830, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 16, hour: 17, minute: 21, second: 18, millisecond: 434, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 27, second: 5, millisecond: 540, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 6, hour: 20, minute: 22, second: 58, millisecond: 39, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 7, hour: 5, minute: 7, second: 7, millisecond: 960, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 17, hour: 15, minute: 37, second: 26, millisecond: 318, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 7, hour: 8, minute: 44, second: 17, millisecond: 801, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 15, hour: 1, minute: 49, second: 44, millisecond: 717, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 16, hour: 15, minute: 16, second: 16, millisecond: 603, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 18, hour: 19, minute: 28, second: 15, millisecond: 522, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 1, hour: 3, minute: 22, second: 49, millisecond: 558, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 5, hour: 9, minute: 17, second: 53, millisecond: 35, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 14, minute: 1, second: 54, millisecond: 716, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 16, hour: 6, minute: 9, second: 34, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 9, second: 26, millisecond: 255, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 14, hour: 3, minute: 39, second: 8, millisecond: 465, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 7, hour: 16, minute: 54, second: 49, millisecond: 119, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 5, hour: 2, minute: 5, second: 24, millisecond: 71, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 1, hour: 11, minute: 31, second: 1, millisecond: 616, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 2, minute: 47, second: 20, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 11, hour: 19, minute: 3, second: 28, millisecond: 484, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 1, hour: 21, minute: 24, second: 18, millisecond: 967, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 13, hour: 17, minute: 28, second: 48, millisecond: 464, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 15, hour: 14, minute: 13, second: 55, millisecond: 23, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 4, hour: 14, minute: 18, second: 30, millisecond: 764, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 12, hour: 17, minute: 39, second: 13, millisecond: 8, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 5, hour: 8, minute: 46, second: 34, millisecond: 760, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 3, hour: 14, minute: 45, second: 11, millisecond: 934, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 15, hour: 11, minute: 43, second: 50, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 14, hour: 10, minute: 47, second: 33, millisecond: 133, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 11, hour: 13, minute: 27, second: 20, millisecond: 452, kind: DateTimeKind.Local))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 15, hour: 20, minute: 13, second: 23, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 1, hour: 21, minute: 51, second: 28, millisecond: 182, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 6, hour: 8, minute: 16, second: 2, millisecond: 3, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 7, hour: 21, minute: 23, second: 48, millisecond: 221, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 1, hour: 14, minute: 17, second: 55, millisecond: 636, kind: DateTimeKind.Local))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 8, hour: 22, minute: 36, second: 51, millisecond: 668, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 12, hour: 6, minute: 19, second: 28, millisecond: 344, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 16, hour: 5, minute: 30, second: 43, millisecond: 68, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 6, hour: 21, minute: 1, second: 5, millisecond: 393, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 15, hour: 20, minute: 35, second: 17, millisecond: 758, kind: DateTimeKind.Local))));//Value

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
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 17, hour: 2, minute: 1, second: 26, millisecond: 251, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 17, hour: 2, minute: 3, second: 41, millisecond: 973, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 10, hour: 10, minute: 37, second: 10, millisecond: 925, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 4, hour: 13, minute: 10, second: 43, millisecond: 942, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 17, hour: 8, minute: 28, second: 2, millisecond: 363, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 9, minute: 10, second: 36, millisecond: 994, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 1, minute: 46, second: 25, millisecond: 680, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 20, minute: 52, second: 16, millisecond: 448, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 1, hour: 14, minute: 21, second: 1, millisecond: 394, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 9, hour: 10, minute: 38, second: 36, millisecond: 505, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 6, hour: 2, minute: 55, second: 35, millisecond: 172, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 17, hour: 8, minute: 13, second: 8, millisecond: 566, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 41, second: 39, millisecond: 510, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 4, hour: 5, minute: 45, second: 17, millisecond: 834, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 1, hour: 19, minute: 1, second: 12, millisecond: 592, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 6, hour: 3, minute: 24, second: 35, millisecond: 40, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 12, hour: 22, minute: 36, second: 29, millisecond: 780, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 17, hour: 22, minute: 56, second: 9, millisecond: 318, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 1, hour: 4, minute: 58, second: 5, millisecond: 351, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 5, hour: 22, minute: 34, second: 15, millisecond: 235, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 13, hour: 8, minute: 1, second: 56, millisecond: 620, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 1, hour: 2, minute: 3, second: 50, millisecond: 111, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 16, hour: 16, minute: 20, second: 54, millisecond: 921, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 17, hour: 5, minute: 45, second: 56, millisecond: 351, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 14, hour: 15, minute: 20, second: 12, millisecond: 450, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 1, hour: 2, minute: 57, second: 53, millisecond: 230, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 17, hour: 17, minute: 17, second: 31, millisecond: 987, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 6, hour: 17, minute: 50, second: 11, millisecond: 513, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 7, hour: 2, minute: 22, second: 26, millisecond: 5, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 13, hour: 13, minute: 55, second: 23, millisecond: 788, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 7, hour: 20, minute: 44, second: 13, millisecond: 708, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 13, hour: 5, minute: 14, second: 2, millisecond: 189, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 1, hour: 18, minute: 35, second: 30, millisecond: 182, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 10, hour: 10, minute: 43, second: 2, millisecond: 838, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 16, hour: 1, minute: 5, second: 58, millisecond: 493, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 10, hour: 15, minute: 26, second: 9, millisecond: 538, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 9, hour: 16, minute: 30, second: 7, millisecond: 830, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 16, hour: 17, minute: 21, second: 18, millisecond: 434, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 27, second: 5, millisecond: 540, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 6, hour: 20, minute: 22, second: 58, millisecond: 39, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 7, hour: 5, minute: 7, second: 7, millisecond: 960, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 17, hour: 15, minute: 37, second: 26, millisecond: 318, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 7, hour: 8, minute: 44, second: 17, millisecond: 801, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 15, hour: 1, minute: 49, second: 44, millisecond: 717, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 16, hour: 15, minute: 16, second: 16, millisecond: 603, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 18, hour: 19, minute: 28, second: 15, millisecond: 522, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 1, hour: 3, minute: 22, second: 49, millisecond: 558, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 5, hour: 9, minute: 17, second: 53, millisecond: 35, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 14, minute: 1, second: 54, millisecond: 716, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 16, hour: 6, minute: 9, second: 34, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 3, hour: 16, minute: 9, second: 26, millisecond: 255, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 14, hour: 3, minute: 39, second: 8, millisecond: 465, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 7, hour: 16, minute: 54, second: 49, millisecond: 119, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 5, hour: 2, minute: 5, second: 24, millisecond: 71, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 1, hour: 11, minute: 31, second: 1, millisecond: 616, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 2, minute: 47, second: 20, millisecond: 658, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 11, hour: 19, minute: 3, second: 28, millisecond: 484, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 1, hour: 21, minute: 24, second: 18, millisecond: 967, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 13, hour: 17, minute: 28, second: 48, millisecond: 464, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 15, hour: 14, minute: 13, second: 55, millisecond: 23, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 4, hour: 14, minute: 18, second: 30, millisecond: 764, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 12, hour: 17, minute: 39, second: 13, millisecond: 8, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 5, hour: 8, minute: 46, second: 34, millisecond: 760, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 3, hour: 14, minute: 45, second: 11, millisecond: 934, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 15, hour: 11, minute: 43, second: 50, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 14, hour: 10, minute: 47, second: 33, millisecond: 133, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 11, hour: 13, minute: 27, second: 20, millisecond: 452, kind: DateTimeKind.Local))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 15, hour: 20, minute: 13, second: 23, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 1, hour: 21, minute: 51, second: 28, millisecond: 182, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 6, hour: 8, minute: 16, second: 2, millisecond: 3, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 7, hour: 21, minute: 23, second: 48, millisecond: 221, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 1, hour: 14, minute: 17, second: 55, millisecond: 636, kind: DateTimeKind.Local))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 8, hour: 22, minute: 36, second: 51, millisecond: 668, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 12, hour: 6, minute: 19, second: 28, millisecond: 344, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 16, hour: 5, minute: 30, second: 43, millisecond: 68, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 6, hour: 21, minute: 1, second: 5, millisecond: 393, kind: DateTimeKind.Local))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 15, hour: 20, minute: 35, second: 17, millisecond: 758, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


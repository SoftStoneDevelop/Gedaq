

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
    Id = 7,
    Value = new DateTime(year: 1922, month: 10, day: 12, hour: 1, minute: 42, second: 57, millisecond: 646, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 53, second: 43, millisecond: 42, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 13,
    Value = new DateTime(year: 1918, month: 10, day: 19, hour: 22, minute: 51, second: 43, millisecond: 255, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 3,
    Value = new DateTime(year: 1986, month: 10, day: 8, hour: 14, minute: 18, second: 7, millisecond: 289, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1981, month: 10, day: 16, hour: 18, minute: 56, second: 39, millisecond: 733, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 2017, month: 10, day: 11, hour: 5, minute: 34, second: 55, millisecond: 658, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 16,
    Value = new DateTime(year: 2004, month: 10, day: 3, hour: 3, minute: 22, second: 23, millisecond: 810, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 25,
    Value = new DateTime(year: 1946, month: 10, day: 1, hour: 12, minute: 17, second: 12, millisecond: 628, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 11,
    Value = new DateTime(year: 1991, month: 10, day: 14, hour: 13, minute: 25, second: 28, millisecond: 498, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2016, month: 10, day: 2, hour: 14, minute: 56, second: 56, millisecond: 160, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1962, month: 10, day: 2, hour: 14, minute: 53, second: 21, millisecond: 981, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 29,
    Value = new DateTime(year: 1986, month: 10, day: 14, hour: 4, minute: 8, second: 39, millisecond: 802, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 38,
    Value = new DateTime(year: 1966, month: 10, day: 11, hour: 8, minute: 15, second: 53, millisecond: 875, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 13,
    Value = new DateTime(year: 1941, month: 10, day: 6, hour: 3, minute: 6, second: 5, millisecond: 748, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2009, month: 10, day: 14, hour: 3, minute: 2, second: 45, millisecond: 749, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 42,
    Value = new DateTime(year: 1964, month: 10, day: 4, hour: 13, minute: 19, second: 18, millisecond: 619, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 43,
    Value = new DateTime(year: 1925, month: 10, day: 8, hour: 1, minute: 32, second: 56, millisecond: 281, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 19,
    Value = new DateTime(year: 1965, month: 10, day: 4, hour: 6, minute: 14, second: 41, millisecond: 181, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 40, second: 57, millisecond: 459, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 44,
    Value = new DateTime(year: 1944, month: 10, day: 2, hour: 13, minute: 14, second: 32, millisecond: 177, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 46,
    Value = new DateTime(year: 1999, month: 10, day: 19, hour: 6, minute: 27, second: 32, millisecond: 289, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 20,
    Value = new DateTime(year: 1927, month: 10, day: 17, hour: 15, minute: 45, second: 56, millisecond: 838, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1977, month: 10, day: 14, hour: 20, minute: 41, second: 54, millisecond: 993, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 50,
    Value = new DateTime(year: 1957, month: 10, day: 16, hour: 7, minute: 18, second: 9, millisecond: 633, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 54,
    Value = new DateTime(year: 1921, month: 10, day: 7, hour: 11, minute: 29, second: 56, millisecond: 644, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 25,
    Value = new DateTime(year: 1942, month: 10, day: 18, hour: 16, minute: 56, second: 46, millisecond: 346, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1931, month: 10, day: 5, hour: 6, minute: 32, second: 44, millisecond: 523, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1935, month: 10, day: 2, hour: 17, minute: 20, second: 42, millisecond: 10, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 58,
    Value = new DateTime(year: 1974, month: 10, day: 11, hour: 7, minute: 9, second: 39, millisecond: 923, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1937, month: 10, day: 6, hour: 14, minute: 16, second: 12, millisecond: 263, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 65,
    Value = new DateTime(year: 1924, month: 10, day: 2, hour: 21, minute: 52, second: 57, millisecond: 217, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 30,
    Value = new DateTime(year: 2012, month: 10, day: 12, hour: 5, minute: 16, second: 26, millisecond: 261, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2008, month: 10, day: 19, hour: 16, minute: 36, second: 19, millisecond: 991, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 74,
    Value = new DateTime(year: 1922, month: 10, day: 2, hour: 17, minute: 43, second: 43, millisecond: 205, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1990, month: 10, day: 4, hour: 21, minute: 47, second: 28, millisecond: 594, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 82,
    Value = new DateTime(year: 1950, month: 10, day: 15, hour: 2, minute: 33, second: 51, millisecond: 75, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 35,
    Value = new DateTime(year: 1986, month: 10, day: 3, hour: 15, minute: 31, second: 35, millisecond: 995, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 83,
    Value = new DateTime(year: 2006, month: 10, day: 11, hour: 22, minute: 12, second: 1, millisecond: 138, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 92,
    Value = new DateTime(year: 1978, month: 10, day: 5, hour: 4, minute: 22, second: 5, millisecond: 163, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 44,
    Value = new DateTime(year: 1934, month: 10, day: 15, hour: 3, minute: 25, second: 16, millisecond: 703, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 93,
    Value = new DateTime(year: 1977, month: 10, day: 18, hour: 13, minute: 17, second: 38, millisecond: 246, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1939, month: 10, day: 7, hour: 10, minute: 52, second: 27, millisecond: 475, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 99,
    Value = new DateTime(year: 1955, month: 10, day: 1, hour: 20, minute: 3, second: 14, millisecond: 497, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 47,
    Value = new DateTime(year: 1974, month: 10, day: 4, hour: 17, minute: 22, second: 7, millisecond: 996, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2003, month: 10, day: 9, hour: 20, minute: 15, second: 6, millisecond: 588, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 101,
    Value = new DateTime(year: 1961, month: 10, day: 4, hour: 2, minute: 53, second: 30, millisecond: 565, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 28, second: 41, millisecond: 458, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 104,
    Value = new DateTime(year: 1978, month: 10, day: 15, hour: 10, minute: 38, second: 47, millisecond: 567, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 53,
    Value = new DateTime(year: 1985, month: 10, day: 4, hour: 22, minute: 19, second: 6, millisecond: 470, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1995, month: 10, day: 11, hour: 18, minute: 46, second: 24, millisecond: 522, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 112,
    Value = new DateTime(year: 1960, month: 10, day: 8, hour: 10, minute: 48, second: 28, millisecond: 408, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 27, second: 36, millisecond: 610, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 115,
    Value = new DateTime(year: 1938, month: 10, day: 14, hour: 20, minute: 19, second: 15, millisecond: 267, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 58,
    Value = new DateTime(year: 1933, month: 10, day: 6, hour: 1, minute: 45, second: 16, millisecond: 209, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2015, month: 10, day: 5, hour: 13, minute: 57, second: 37, millisecond: 672, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 116,
    Value = new DateTime(year: 1948, month: 10, day: 7, hour: 5, minute: 57, second: 16, millisecond: 47, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 124,
    Value = new DateTime(year: 1952, month: 10, day: 8, hour: 20, minute: 37, second: 15, millisecond: 679, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 60,
    Value = new DateTime(year: 1939, month: 10, day: 6, hour: 22, minute: 8, second: 31, millisecond: 238, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1967, month: 10, day: 2, hour: 6, minute: 10, second: 17, millisecond: 456, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1979, month: 10, day: 1, hour: 11, minute: 33, second: 51, millisecond: 451, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 128,
    Value = new DateTime(year: 2000, month: 10, day: 9, hour: 15, minute: 57, second: 35, millisecond: 412, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2009, month: 10, day: 15, hour: 5, minute: 33, second: 41, millisecond: 773, kind: DateTimeKind.Local),
},
            new DateTimedatetime2E0M
{
    Id = 134,
    Value = new DateTime(year: 1922, month: 10, day: 11, hour: 10, minute: 35, second: 14, millisecond: 684, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 65,
    Value = new DateTime(year: 1979, month: 10, day: 1, hour: 16, minute: 24, second: 39, millisecond: 904, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1946, month: 10, day: 16, hour: 17, minute: 58, second: 32, millisecond: 146, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 136,
    Value = new DateTime(year: 1952, month: 10, day: 1, hour: 8, minute: 39, second: 26, millisecond: 156, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 145,
    Value = new DateTime(year: 1940, month: 10, day: 11, hour: 22, minute: 3, second: 45, millisecond: 274, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 72,
    Value = new DateTime(year: 1984, month: 10, day: 4, hour: 4, minute: 42, second: 42, millisecond: 273, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1961, month: 10, day: 16, hour: 10, minute: 14, second: 35, millisecond: 274, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 147,
    Value = new DateTime(year: 1975, month: 10, day: 15, hour: 11, minute: 55, second: 19, millisecond: 24, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 152,
    Value = new DateTime(year: 2018, month: 10, day: 11, hour: 11, minute: 22, second: 35, millisecond: 365, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 78,
    Value = new DateTime(year: 1951, month: 10, day: 14, hour: 9, minute: 16, second: 16, millisecond: 372, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 158,
    Value = new DateTime(year: 1985, month: 10, day: 10, hour: 13, minute: 38, second: 17, millisecond: 687, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 164,
    Value = new DateTime(year: 1995, month: 10, day: 17, hour: 3, minute: 41, second: 4, millisecond: 880, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime2E0MI
{
    Id = 84,
    Value = new DateTime(year: 2003, month: 10, day: 19, hour: 12, minute: 22, second: 21, millisecond: 661, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1948, month: 10, day: 10, hour: 12, minute: 58, second: 48, millisecond: 518, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime2E0M
{
    Id = 169,
    Value = new DateTime(year: 1954, month: 10, day: 6, hour: 12, minute: 33, second: 47, millisecond: 794, kind: DateTimeKind.Local),
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[5], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[6], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[7], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[8], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[9], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[10], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[11], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[12], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[13], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[14], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[15], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[16], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[17], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[18], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[16],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[17],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[18],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[19],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[20],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[21],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[22],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[23],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[24],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[25],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[26],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[27],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[28],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 74, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[23],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 43, query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[21],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[22],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[23],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[24],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[25],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[26],_testData[34], false);
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[17], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[18], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[19], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[20], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[10],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[11],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[12],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[13],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[14],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[15],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[16],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateTimedatetime2E0M.AssertModel(models[0],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[1],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[2],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[3],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[4],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[5],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[6],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[7],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[8],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(models[9],_testData[34], false);
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDateTimedatetime2E0M.AssertModel(secondItems2[13],_testData[34], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[8], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[9], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[10], false);
                        DateTimedatetime2E0M.AssertModel(models[3],_testData[11], false);
                        DateTimedatetime2E0M.AssertModel(models[4],_testData[12], false);
                        DateTimedatetime2E0M.AssertModel(models[5],_testData[13], false);
                        DateTimedatetime2E0M.AssertModel(models[6],_testData[14], false);
                        DateTimedatetime2E0M.AssertModel(models[7],_testData[15], false);
                        DateTimedatetime2E0M.AssertModel(models[8],_testData[16], false);
                        DateTimedatetime2E0M.AssertModel(models[9],_testData[17], false);
                        DateTimedatetime2E0M.AssertModel(models[10],_testData[18], false);
                        DateTimedatetime2E0M.AssertModel(models[11],_testData[19], false);
                        DateTimedatetime2E0M.AssertModel(models[12],_testData[20], false);
                        DateTimedatetime2E0M.AssertModel(models[13],_testData[21], false);
                        DateTimedatetime2E0M.AssertModel(models[14],_testData[22], false);
                        DateTimedatetime2E0M.AssertModel(models[15],_testData[23], false);
                        DateTimedatetime2E0M.AssertModel(models[16],_testData[24], false);
                        DateTimedatetime2E0M.AssertModel(models[17],_testData[25], false);
                        DateTimedatetime2E0M.AssertModel(models[18],_testData[26], false);
                        DateTimedatetime2E0M.AssertModel(models[19],_testData[27], false);
                        DateTimedatetime2E0M.AssertModel(models[20],_testData[28], false);
                        DateTimedatetime2E0M.AssertModel(models[21],_testData[29], false);
                        DateTimedatetime2E0M.AssertModel(models[22],_testData[30], false);
                        DateTimedatetime2E0M.AssertModel(models[23],_testData[31], false);
                        DateTimedatetime2E0M.AssertModel(models[24],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[25],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatch(connection, 152, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DateTimedatetime2E0M.AssertModel(models[0],_testData[32], false);
                        DateTimedatetime2E0M.AssertModel(models[1],_testData[33], false);
                        DateTimedatetime2E0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                DateTimedatetime2E0M.AssertModel(models[0],_testData[29], false);
                DateTimedatetime2E0M.AssertModel(models[1],_testData[30], false);
                DateTimedatetime2E0M.AssertModel(models[2],_testData[31], false);
                DateTimedatetime2E0M.AssertModel(models[3],_testData[32], false);
                DateTimedatetime2E0M.AssertModel(models[4],_testData[33], false);
                DateTimedatetime2E0M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 12, hour: 1, minute: 42, second: 57, millisecond: 646, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 53, second: 43, millisecond: 42, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 19, hour: 22, minute: 51, second: 43, millisecond: 255, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 8, hour: 14, minute: 18, second: 7, millisecond: 289, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 16, hour: 18, minute: 56, second: 39, millisecond: 733, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 11, hour: 5, minute: 34, second: 55, millisecond: 658, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 3, hour: 3, minute: 22, second: 23, millisecond: 810, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 1, hour: 12, minute: 17, second: 12, millisecond: 628, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 14, hour: 13, minute: 25, second: 28, millisecond: 498, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 2, hour: 14, minute: 56, second: 56, millisecond: 160, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 2, hour: 14, minute: 53, second: 21, millisecond: 981, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 14, hour: 4, minute: 8, second: 39, millisecond: 802, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 11, hour: 8, minute: 15, second: 53, millisecond: 875, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 3, minute: 6, second: 5, millisecond: 748, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 14, hour: 3, minute: 2, second: 45, millisecond: 749, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 4, hour: 13, minute: 19, second: 18, millisecond: 619, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 8, hour: 1, minute: 32, second: 56, millisecond: 281, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 6, minute: 14, second: 41, millisecond: 181, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 40, second: 57, millisecond: 459, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 2, hour: 13, minute: 14, second: 32, millisecond: 177, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 19, hour: 6, minute: 27, second: 32, millisecond: 289, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 17, hour: 15, minute: 45, second: 56, millisecond: 838, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 20, minute: 41, second: 54, millisecond: 993, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 16, hour: 7, minute: 18, second: 9, millisecond: 633, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 7, hour: 11, minute: 29, second: 56, millisecond: 644, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 18, hour: 16, minute: 56, second: 46, millisecond: 346, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 5, hour: 6, minute: 32, second: 44, millisecond: 523, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 2, hour: 17, minute: 20, second: 42, millisecond: 10, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 11, hour: 7, minute: 9, second: 39, millisecond: 923, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 14, minute: 16, second: 12, millisecond: 263, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 2, hour: 21, minute: 52, second: 57, millisecond: 217, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 12, hour: 5, minute: 16, second: 26, millisecond: 261, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 19, hour: 16, minute: 36, second: 19, millisecond: 991, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 2, hour: 17, minute: 43, second: 43, millisecond: 205, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 4, hour: 21, minute: 47, second: 28, millisecond: 594, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 15, hour: 2, minute: 33, second: 51, millisecond: 75, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 3, hour: 15, minute: 31, second: 35, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 11, hour: 22, minute: 12, second: 1, millisecond: 138, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 5, hour: 4, minute: 22, second: 5, millisecond: 163, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 15, hour: 3, minute: 25, second: 16, millisecond: 703, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 13, minute: 17, second: 38, millisecond: 246, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 7, hour: 10, minute: 52, second: 27, millisecond: 475, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 1, hour: 20, minute: 3, second: 14, millisecond: 497, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 17, minute: 22, second: 7, millisecond: 996, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 9, hour: 20, minute: 15, second: 6, millisecond: 588, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 4, hour: 2, minute: 53, second: 30, millisecond: 565, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 28, second: 41, millisecond: 458, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 15, hour: 10, minute: 38, second: 47, millisecond: 567, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 4, hour: 22, minute: 19, second: 6, millisecond: 470, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 18, minute: 46, second: 24, millisecond: 522, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 8, hour: 10, minute: 48, second: 28, millisecond: 408, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 27, second: 36, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 14, hour: 20, minute: 19, second: 15, millisecond: 267, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 6, hour: 1, minute: 45, second: 16, millisecond: 209, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 5, hour: 13, minute: 57, second: 37, millisecond: 672, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 7, hour: 5, minute: 57, second: 16, millisecond: 47, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 20, minute: 37, second: 15, millisecond: 679, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 6, hour: 22, minute: 8, second: 31, millisecond: 238, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 2, hour: 6, minute: 10, second: 17, millisecond: 456, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 1, hour: 11, minute: 33, second: 51, millisecond: 451, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 9, hour: 15, minute: 57, second: 35, millisecond: 412, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 15, hour: 5, minute: 33, second: 41, millisecond: 773, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 11, hour: 10, minute: 35, second: 14, millisecond: 684, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 1, hour: 16, minute: 24, second: 39, millisecond: 904, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 17, minute: 58, second: 32, millisecond: 146, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 1, hour: 8, minute: 39, second: 26, millisecond: 156, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 22, minute: 3, second: 45, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 4, hour: 4, minute: 42, second: 42, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 16, hour: 10, minute: 14, second: 35, millisecond: 274, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 15, hour: 11, minute: 55, second: 19, millisecond: 24, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 11, hour: 11, minute: 22, second: 35, millisecond: 365, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 14, hour: 9, minute: 16, second: 16, millisecond: 372, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 10, hour: 13, minute: 38, second: 17, millisecond: 687, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 17, hour: 3, minute: 41, second: 4, millisecond: 880, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 19, hour: 12, minute: 22, second: 21, millisecond: 661, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 10, hour: 12, minute: 58, second: 48, millisecond: 518, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 6, hour: 12, minute: 33, second: 47, millisecond: 794, kind: DateTimeKind.Local))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 12, hour: 1, minute: 42, second: 57, millisecond: 646, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 3, hour: 4, minute: 53, second: 43, millisecond: 42, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 19, hour: 22, minute: 51, second: 43, millisecond: 255, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 8, hour: 14, minute: 18, second: 7, millisecond: 289, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 16, hour: 18, minute: 56, second: 39, millisecond: 733, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 11, hour: 5, minute: 34, second: 55, millisecond: 658, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 3, hour: 3, minute: 22, second: 23, millisecond: 810, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 1, hour: 12, minute: 17, second: 12, millisecond: 628, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 14, hour: 13, minute: 25, second: 28, millisecond: 498, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 2, hour: 14, minute: 56, second: 56, millisecond: 160, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 2, hour: 14, minute: 53, second: 21, millisecond: 981, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 14, hour: 4, minute: 8, second: 39, millisecond: 802, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 11, hour: 8, minute: 15, second: 53, millisecond: 875, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 3, minute: 6, second: 5, millisecond: 748, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 14, hour: 3, minute: 2, second: 45, millisecond: 749, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 4, hour: 13, minute: 19, second: 18, millisecond: 619, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 8, hour: 1, minute: 32, second: 56, millisecond: 281, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 6, minute: 14, second: 41, millisecond: 181, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 10, minute: 40, second: 57, millisecond: 459, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 2, hour: 13, minute: 14, second: 32, millisecond: 177, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 19, hour: 6, minute: 27, second: 32, millisecond: 289, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 17, hour: 15, minute: 45, second: 56, millisecond: 838, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 20, minute: 41, second: 54, millisecond: 993, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 16, hour: 7, minute: 18, second: 9, millisecond: 633, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 7, hour: 11, minute: 29, second: 56, millisecond: 644, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 18, hour: 16, minute: 56, second: 46, millisecond: 346, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 5, hour: 6, minute: 32, second: 44, millisecond: 523, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 2, hour: 17, minute: 20, second: 42, millisecond: 10, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 11, hour: 7, minute: 9, second: 39, millisecond: 923, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 6, hour: 14, minute: 16, second: 12, millisecond: 263, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 2, hour: 21, minute: 52, second: 57, millisecond: 217, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 12, hour: 5, minute: 16, second: 26, millisecond: 261, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 19, hour: 16, minute: 36, second: 19, millisecond: 991, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 2, hour: 17, minute: 43, second: 43, millisecond: 205, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 4, hour: 21, minute: 47, second: 28, millisecond: 594, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 15, hour: 2, minute: 33, second: 51, millisecond: 75, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 3, hour: 15, minute: 31, second: 35, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 11, hour: 22, minute: 12, second: 1, millisecond: 138, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 5, hour: 4, minute: 22, second: 5, millisecond: 163, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 15, hour: 3, minute: 25, second: 16, millisecond: 703, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 13, minute: 17, second: 38, millisecond: 246, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 7, hour: 10, minute: 52, second: 27, millisecond: 475, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 1, hour: 20, minute: 3, second: 14, millisecond: 497, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 17, minute: 22, second: 7, millisecond: 996, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 9, hour: 20, minute: 15, second: 6, millisecond: 588, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 4, hour: 2, minute: 53, second: 30, millisecond: 565, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 3, hour: 17, minute: 28, second: 41, millisecond: 458, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 15, hour: 10, minute: 38, second: 47, millisecond: 567, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 4, hour: 22, minute: 19, second: 6, millisecond: 470, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 18, minute: 46, second: 24, millisecond: 522, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 8, hour: 10, minute: 48, second: 28, millisecond: 408, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 2, hour: 4, minute: 27, second: 36, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 14, hour: 20, minute: 19, second: 15, millisecond: 267, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1933, month: 10, day: 6, hour: 1, minute: 45, second: 16, millisecond: 209, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 5, hour: 13, minute: 57, second: 37, millisecond: 672, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 7, hour: 5, minute: 57, second: 16, millisecond: 47, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 20, minute: 37, second: 15, millisecond: 679, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 6, hour: 22, minute: 8, second: 31, millisecond: 238, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 2, hour: 6, minute: 10, second: 17, millisecond: 456, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 1, hour: 11, minute: 33, second: 51, millisecond: 451, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 9, hour: 15, minute: 57, second: 35, millisecond: 412, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 15, hour: 5, minute: 33, second: 41, millisecond: 773, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 11, hour: 10, minute: 35, second: 14, millisecond: 684, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 1, hour: 16, minute: 24, second: 39, millisecond: 904, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 16, hour: 17, minute: 58, second: 32, millisecond: 146, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 1, hour: 8, minute: 39, second: 26, millisecond: 156, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 22, minute: 3, second: 45, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 4, hour: 4, minute: 42, second: 42, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 16, hour: 10, minute: 14, second: 35, millisecond: 274, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 15, hour: 11, minute: 55, second: 19, millisecond: 24, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 11, hour: 11, minute: 22, second: 35, millisecond: 365, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 14, hour: 9, minute: 16, second: 16, millisecond: 372, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 10, hour: 13, minute: 38, second: 17, millisecond: 687, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 17, hour: 3, minute: 41, second: 4, millisecond: 880, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 19, hour: 12, minute: 22, second: 21, millisecond: 661, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 10, hour: 12, minute: 58, second: 48, millisecond: 518, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 6, hour: 12, minute: 33, second: 47, millisecond: 794, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


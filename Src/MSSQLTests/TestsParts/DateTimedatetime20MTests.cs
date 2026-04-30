

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

        private readonly DateTimedatetime20M[] _testData = new DateTimedatetime20M[]
        {
            new DateTimedatetime20M
{
    Id = 7,
    Value = new DateTime(year: 1936, month: 10, day: 13, hour: 21, minute: 10, second: 7, millisecond: 502, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 16,
    Value = new DateTime(year: 1957, month: 10, day: 14, hour: 1, minute: 52, second: 46, millisecond: 435, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 8,
    Value = new DateTime(year: 1964, month: 10, day: 8, hour: 6, minute: 32, second: 9, millisecond: 911, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 24,
    Value = new DateTime(year: 2016, month: 10, day: 11, hour: 18, minute: 26, second: 37, millisecond: 771, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 30,
    Value = new DateTime(year: 1924, month: 10, day: 13, hour: 9, minute: 22, second: 37, millisecond: 356, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 10,
    Value = new DateTime(year: 2007, month: 10, day: 19, hour: 1, minute: 21, second: 1, millisecond: 609, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 2012, month: 10, day: 8, hour: 19, minute: 5, second: 47, millisecond: 594, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 33,
    Value = new DateTime(year: 1960, month: 10, day: 16, hour: 5, minute: 45, second: 25, millisecond: 297, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 38,
    Value = new DateTime(year: 1992, month: 10, day: 8, hour: 4, minute: 29, second: 38, millisecond: 691, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 15,
    Value = new DateTime(year: 1917, month: 10, day: 18, hour: 21, minute: 15, second: 58, millisecond: 449, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 39,
    Value = new DateTime(year: 1997, month: 10, day: 17, hour: 12, minute: 18, second: 10, millisecond: 856, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 42,
    Value = new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 49, second: 8, millisecond: 393, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 20,
    Value = new DateTime(year: 1978, month: 10, day: 7, hour: 8, minute: 48, second: 15, millisecond: 339, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1954, month: 10, day: 18, hour: 7, minute: 46, second: 56, millisecond: 610, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 50,
    Value = new DateTime(year: 1947, month: 10, day: 12, hour: 3, minute: 33, second: 37, millisecond: 345, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 52,
    Value = new DateTime(year: 1998, month: 10, day: 3, hour: 6, minute: 16, second: 50, millisecond: 202, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 28,
    Value = new DateTime(year: 2010, month: 10, day: 17, hour: 9, minute: 17, second: 51, millisecond: 575, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1969, month: 10, day: 5, hour: 20, minute: 54, second: 10, millisecond: 953, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 2007, month: 10, day: 3, hour: 2, minute: 36, second: 17, millisecond: 73, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 54,
    Value = new DateTime(year: 1942, month: 10, day: 11, hour: 15, minute: 17, second: 52, millisecond: 315, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1996, month: 10, day: 2, hour: 1, minute: 32, second: 5, millisecond: 890, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 62,
    Value = new DateTime(year: 2002, month: 10, day: 5, hour: 6, minute: 41, second: 48, millisecond: 48, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 32,
    Value = new DateTime(year: 1959, month: 10, day: 6, hour: 4, minute: 17, second: 30, millisecond: 458, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1986, month: 10, day: 1, hour: 13, minute: 10, second: 45, millisecond: 107, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1938, month: 10, day: 16, hour: 15, minute: 12, second: 55, millisecond: 973, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 71,
    Value = new DateTime(year: 1955, month: 10, day: 16, hour: 10, minute: 2, second: 4, millisecond: 49, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1936, month: 10, day: 15, hour: 1, minute: 14, second: 35, millisecond: 489, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 79,
    Value = new DateTime(year: 1942, month: 10, day: 15, hour: 16, minute: 34, second: 48, millisecond: 917, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 41,
    Value = new DateTime(year: 2016, month: 10, day: 9, hour: 15, minute: 30, second: 27, millisecond: 944, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1949, month: 10, day: 12, hour: 14, minute: 45, second: 1, millisecond: 188, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 81,
    Value = new DateTime(year: 1938, month: 10, day: 2, hour: 2, minute: 19, second: 29, millisecond: 229, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1986, month: 10, day: 12, hour: 20, minute: 34, second: 25, millisecond: 725, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 85,
    Value = new DateTime(year: 1984, month: 10, day: 1, hour: 3, minute: 56, second: 8, millisecond: 401, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 47,
    Value = new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 21, second: 26, millisecond: 918, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1954, month: 10, day: 2, hour: 1, minute: 6, second: 41, millisecond: 511, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 87,
    Value = new DateTime(year: 1984, month: 10, day: 19, hour: 13, minute: 46, second: 26, millisecond: 758, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 93,
    Value = new DateTime(year: 1931, month: 10, day: 19, hour: 7, minute: 24, second: 50, millisecond: 345, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 52,
    Value = new DateTime(year: 1987, month: 10, day: 8, hour: 21, minute: 17, second: 37, millisecond: 665, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1978, month: 10, day: 4, hour: 8, minute: 7, second: 21, millisecond: 264, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 97,
    Value = new DateTime(year: 1975, month: 10, day: 4, hour: 17, minute: 24, second: 26, millisecond: 925, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1977, month: 10, day: 2, hour: 6, minute: 1, second: 1, millisecond: 71, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 98,
    Value = new DateTime(year: 1957, month: 10, day: 4, hour: 10, minute: 51, second: 21, millisecond: 211, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 54,
    Value = new DateTime(year: 2000, month: 10, day: 18, hour: 14, minute: 1, second: 45, millisecond: 27, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 105,
    Value = new DateTime(year: 2017, month: 10, day: 6, hour: 22, minute: 39, second: 4, millisecond: 837, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 114,
    Value = new DateTime(year: 1948, month: 10, day: 15, hour: 20, minute: 12, second: 4, millisecond: 214, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 59,
    Value = new DateTime(year: 2001, month: 10, day: 9, hour: 17, minute: 1, second: 42, millisecond: 992, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1998, month: 10, day: 17, hour: 9, minute: 40, second: 43, millisecond: 991, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 117,
    Value = new DateTime(year: 1919, month: 10, day: 7, hour: 21, minute: 24, second: 1, millisecond: 459, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 126,
    Value = new DateTime(year: 1980, month: 10, day: 19, hour: 4, minute: 44, second: 44, millisecond: 488, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 62,
    Value = new DateTime(year: 1945, month: 10, day: 5, hour: 8, minute: 8, second: 20, millisecond: 814, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1923, month: 10, day: 6, hour: 9, minute: 18, second: 35, millisecond: 116, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 135,
    Value = new DateTime(year: 1972, month: 10, day: 11, hour: 20, minute: 57, second: 30, millisecond: 221, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 137,
    Value = new DateTime(year: 2001, month: 10, day: 19, hour: 10, minute: 50, second: 49, millisecond: 523, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 65,
    Value = new DateTime(year: 1928, month: 10, day: 7, hour: 4, minute: 11, second: 30, millisecond: 361, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1985, month: 10, day: 11, hour: 4, minute: 22, second: 24, millisecond: 207, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 144,
    Value = new DateTime(year: 2016, month: 10, day: 13, hour: 17, minute: 1, second: 11, millisecond: 603, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1937, month: 10, day: 2, hour: 14, minute: 37, second: 44, millisecond: 675, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 152,
    Value = new DateTime(year: 1967, month: 10, day: 8, hour: 3, minute: 51, second: 50, millisecond: 442, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 73,
    Value = new DateTime(year: 2002, month: 10, day: 18, hour: 16, minute: 47, second: 33, millisecond: 312, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1999, month: 10, day: 14, hour: 15, minute: 48, second: 10, millisecond: 840, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1995, month: 10, day: 11, hour: 1, minute: 39, second: 31, millisecond: 200, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 159,
    Value = new DateTime(year: 2014, month: 10, day: 15, hour: 7, minute: 31, second: 2, millisecond: 565, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 165,
    Value = new DateTime(year: 1934, month: 10, day: 6, hour: 13, minute: 1, second: 38, millisecond: 172, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 74,
    Value = new DateTime(year: 1935, month: 10, day: 16, hour: 16, minute: 17, second: 54, millisecond: 766, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1974, month: 10, day: 4, hour: 6, minute: 48, second: 12, millisecond: 751, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1998, month: 10, day: 18, hour: 4, minute: 35, second: 10, millisecond: 250, kind: DateTimeKind.Local),
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20mi(
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
INSERT INTO dbo.datetimedatetime20mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20m(
	id,
    value,
    nullablevalue,
    datetimedatetime20mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime20mi_id
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
                parametrName: "datetimedatetime20mi_id", 
                methodParametrName: "datetimedatetime20mi_id", 
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
INSERT INTO dbo.datetimedatetime20m(
	id,
    value,
    nullablevalue,
    datetimedatetime20mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime20mi_id
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
                parametrName: "datetimedatetime20mi_id", 
                methodParametrName: "datetimedatetime20mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M), typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                await((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                ((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime20M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M), typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                await((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                ((IDateTimeSingleTypedatetime2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateTimedatetime20M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M), typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                await((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[16],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[17],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[18],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[19],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[20],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateTimedatetime20M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DateTimedatetime20M.AssertModel(models[0],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DateTimedatetime20M.AssertModel(models[0],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateTimedatetime20M.AssertModel(models[0],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimedatetime20M.AssertModel(models[0],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M), typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                await((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 71, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 117, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateTimedatetime20M>();
                var models2 = new List<FlatDateTimedatetime20M>();
                ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var firstItems2 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 152, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 137, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
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
FROM dbo.datetimedatetime20m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems1 = new List<FlatDateTimedatetime20M>();
                var secondItems2 = new List<FlatDateTimedatetime20M>();
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateTimedatetime20M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DateTimedatetime20M.AssertModel(models[0],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DateTimedatetime20M.AssertModel(models[0],_testData[9], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[10], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[11], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[12], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[13], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[16],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[17],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[18],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[19],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatch(connection, 97, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DateTimedatetime20M.AssertModel(models[0],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DateTimedatetime20M.AssertModel(models[0],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[29], false);
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
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
DateTimedatetime20M.AssertModel(models[0],_testData[20], false);DateTimedatetime20M.AssertModel(models[1],_testData[21], false);DateTimedatetime20M.AssertModel(models[2],_testData[22], false);DateTimedatetime20M.AssertModel(models[3],_testData[23], false);DateTimedatetime20M.AssertModel(models[4],_testData[24], false);DateTimedatetime20M.AssertModel(models[5],_testData[25], false);DateTimedatetime20M.AssertModel(models[6],_testData[26], false);DateTimedatetime20M.AssertModel(models[7],_testData[27], false);DateTimedatetime20M.AssertModel(models[8],_testData[28], false);DateTimedatetime20M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
DateTimedatetime20M.AssertModel(models[0],_testData[28], false);DateTimedatetime20M.AssertModel(models[1],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 13, hour: 21, minute: 10, second: 7, millisecond: 502, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 14, hour: 1, minute: 52, second: 46, millisecond: 435, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 8, hour: 6, minute: 32, second: 9, millisecond: 911, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 11, hour: 18, minute: 26, second: 37, millisecond: 771, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 13, hour: 9, minute: 22, second: 37, millisecond: 356, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 19, hour: 1, minute: 21, second: 1, millisecond: 609, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 8, hour: 19, minute: 5, second: 47, millisecond: 594, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 16, hour: 5, minute: 45, second: 25, millisecond: 297, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 8, hour: 4, minute: 29, second: 38, millisecond: 691, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 18, hour: 21, minute: 15, second: 58, millisecond: 449, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 17, hour: 12, minute: 18, second: 10, millisecond: 856, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 49, second: 8, millisecond: 393, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 7, hour: 8, minute: 48, second: 15, millisecond: 339, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 7, minute: 46, second: 56, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 12, hour: 3, minute: 33, second: 37, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 3, hour: 6, minute: 16, second: 50, millisecond: 202, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 17, hour: 9, minute: 17, second: 51, millisecond: 575, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 5, hour: 20, minute: 54, second: 10, millisecond: 953, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 3, hour: 2, minute: 36, second: 17, millisecond: 73, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 11, hour: 15, minute: 17, second: 52, millisecond: 315, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 1, minute: 32, second: 5, millisecond: 890, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 6, minute: 41, second: 48, millisecond: 48, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 6, hour: 4, minute: 17, second: 30, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 1, hour: 13, minute: 10, second: 45, millisecond: 107, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 15, minute: 12, second: 55, millisecond: 973, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 10, minute: 2, second: 4, millisecond: 49, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 15, hour: 1, minute: 14, second: 35, millisecond: 489, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 15, hour: 16, minute: 34, second: 48, millisecond: 917, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 9, hour: 15, minute: 30, second: 27, millisecond: 944, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 12, hour: 14, minute: 45, second: 1, millisecond: 188, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 2, hour: 2, minute: 19, second: 29, millisecond: 229, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 12, hour: 20, minute: 34, second: 25, millisecond: 725, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 3, minute: 56, second: 8, millisecond: 401, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 21, second: 26, millisecond: 918, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 2, hour: 1, minute: 6, second: 41, millisecond: 511, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 19, hour: 13, minute: 46, second: 26, millisecond: 758, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 19, hour: 7, minute: 24, second: 50, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 21, minute: 17, second: 37, millisecond: 665, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 4, hour: 8, minute: 7, second: 21, millisecond: 264, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 4, hour: 17, minute: 24, second: 26, millisecond: 925, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 2, hour: 6, minute: 1, second: 1, millisecond: 71, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 4, hour: 10, minute: 51, second: 21, millisecond: 211, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 18, hour: 14, minute: 1, second: 45, millisecond: 27, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 22, minute: 39, second: 4, millisecond: 837, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 15, hour: 20, minute: 12, second: 4, millisecond: 214, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 9, hour: 17, minute: 1, second: 42, millisecond: 992, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 17, hour: 9, minute: 40, second: 43, millisecond: 991, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 7, hour: 21, minute: 24, second: 1, millisecond: 459, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 19, hour: 4, minute: 44, second: 44, millisecond: 488, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 5, hour: 8, minute: 8, second: 20, millisecond: 814, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 6, hour: 9, minute: 18, second: 35, millisecond: 116, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 11, hour: 20, minute: 57, second: 30, millisecond: 221, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 19, hour: 10, minute: 50, second: 49, millisecond: 523, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 7, hour: 4, minute: 11, second: 30, millisecond: 361, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 11, hour: 4, minute: 22, second: 24, millisecond: 207, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 13, hour: 17, minute: 1, second: 11, millisecond: 603, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 2, hour: 14, minute: 37, second: 44, millisecond: 675, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 8, hour: 3, minute: 51, second: 50, millisecond: 442, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 18, hour: 16, minute: 47, second: 33, millisecond: 312, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 15, minute: 48, second: 10, millisecond: 840, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 1, minute: 39, second: 31, millisecond: 200, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 15, hour: 7, minute: 31, second: 2, millisecond: 565, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 13, minute: 1, second: 38, millisecond: 172, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 16, hour: 16, minute: 17, second: 54, millisecond: 766, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 6, minute: 48, second: 12, millisecond: 751, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 18, hour: 4, minute: 35, second: 10, millisecond: 250, kind: DateTimeKind.Local))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 13, hour: 21, minute: 10, second: 7, millisecond: 502, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 14, hour: 1, minute: 52, second: 46, millisecond: 435, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 8, hour: 6, minute: 32, second: 9, millisecond: 911, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 11, hour: 18, minute: 26, second: 37, millisecond: 771, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 13, hour: 9, minute: 22, second: 37, millisecond: 356, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 19, hour: 1, minute: 21, second: 1, millisecond: 609, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 8, hour: 19, minute: 5, second: 47, millisecond: 594, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 16, hour: 5, minute: 45, second: 25, millisecond: 297, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 8, hour: 4, minute: 29, second: 38, millisecond: 691, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 18, hour: 21, minute: 15, second: 58, millisecond: 449, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 17, hour: 12, minute: 18, second: 10, millisecond: 856, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 49, second: 8, millisecond: 393, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 7, hour: 8, minute: 48, second: 15, millisecond: 339, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 18, hour: 7, minute: 46, second: 56, millisecond: 610, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 12, hour: 3, minute: 33, second: 37, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 3, hour: 6, minute: 16, second: 50, millisecond: 202, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 17, hour: 9, minute: 17, second: 51, millisecond: 575, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 5, hour: 20, minute: 54, second: 10, millisecond: 953, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 3, hour: 2, minute: 36, second: 17, millisecond: 73, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 11, hour: 15, minute: 17, second: 52, millisecond: 315, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 2, hour: 1, minute: 32, second: 5, millisecond: 890, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 6, minute: 41, second: 48, millisecond: 48, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 6, hour: 4, minute: 17, second: 30, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 1, hour: 13, minute: 10, second: 45, millisecond: 107, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 16, hour: 15, minute: 12, second: 55, millisecond: 973, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 10, minute: 2, second: 4, millisecond: 49, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 15, hour: 1, minute: 14, second: 35, millisecond: 489, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 15, hour: 16, minute: 34, second: 48, millisecond: 917, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 9, hour: 15, minute: 30, second: 27, millisecond: 944, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 12, hour: 14, minute: 45, second: 1, millisecond: 188, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 2, hour: 2, minute: 19, second: 29, millisecond: 229, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 12, hour: 20, minute: 34, second: 25, millisecond: 725, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 3, minute: 56, second: 8, millisecond: 401, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 9, hour: 10, minute: 21, second: 26, millisecond: 918, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 2, hour: 1, minute: 6, second: 41, millisecond: 511, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 19, hour: 13, minute: 46, second: 26, millisecond: 758, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 19, hour: 7, minute: 24, second: 50, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 21, minute: 17, second: 37, millisecond: 665, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 4, hour: 8, minute: 7, second: 21, millisecond: 264, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 4, hour: 17, minute: 24, second: 26, millisecond: 925, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 2, hour: 6, minute: 1, second: 1, millisecond: 71, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 4, hour: 10, minute: 51, second: 21, millisecond: 211, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 18, hour: 14, minute: 1, second: 45, millisecond: 27, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 6, hour: 22, minute: 39, second: 4, millisecond: 837, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 15, hour: 20, minute: 12, second: 4, millisecond: 214, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 9, hour: 17, minute: 1, second: 42, millisecond: 992, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 17, hour: 9, minute: 40, second: 43, millisecond: 991, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 7, hour: 21, minute: 24, second: 1, millisecond: 459, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 19, hour: 4, minute: 44, second: 44, millisecond: 488, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 5, hour: 8, minute: 8, second: 20, millisecond: 814, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 6, hour: 9, minute: 18, second: 35, millisecond: 116, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 11, hour: 20, minute: 57, second: 30, millisecond: 221, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 19, hour: 10, minute: 50, second: 49, millisecond: 523, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 7, hour: 4, minute: 11, second: 30, millisecond: 361, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 11, hour: 4, minute: 22, second: 24, millisecond: 207, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 13, hour: 17, minute: 1, second: 11, millisecond: 603, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 2, hour: 14, minute: 37, second: 44, millisecond: 675, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 8, hour: 3, minute: 51, second: 50, millisecond: 442, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 18, hour: 16, minute: 47, second: 33, millisecond: 312, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 15, minute: 48, second: 10, millisecond: 840, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 1, minute: 39, second: 31, millisecond: 200, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 15, hour: 7, minute: 31, second: 2, millisecond: 565, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 13, minute: 1, second: 38, millisecond: 172, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 16, hour: 16, minute: 17, second: 54, millisecond: 766, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 4, hour: 6, minute: 48, second: 12, millisecond: 751, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 18, hour: 4, minute: 35, second: 10, millisecond: 250, kind: DateTimeKind.Local))));

            }
        }

#endregion

    }
}


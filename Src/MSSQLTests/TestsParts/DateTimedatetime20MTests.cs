

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
    Id = 4,
    Value = new DateTime(year: 1949, month: 10, day: 15, hour: 22, minute: 39, second: 5, millisecond: 590, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1920, month: 10, day: 13, hour: 9, minute: 38, second: 24, millisecond: 757, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 13,
    Value = new DateTime(year: 2005, month: 10, day: 7, hour: 19, minute: 48, second: 46, millisecond: 379, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 9,
    Value = new DateTime(year: 1917, month: 10, day: 18, hour: 15, minute: 52, second: 55, millisecond: 857, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1965, month: 10, day: 17, hour: 1, minute: 51, second: 43, millisecond: 351, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 15,
    Value = new DateTime(year: 1950, month: 10, day: 8, hour: 19, minute: 20, second: 18, millisecond: 991, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2007, month: 10, day: 5, hour: 3, minute: 20, second: 35, millisecond: 358, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 16,
    Value = new DateTime(year: 1928, month: 10, day: 15, hour: 14, minute: 6, second: 31, millisecond: 591, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 10,
    Value = new DateTime(year: 1948, month: 10, day: 4, hour: 11, minute: 13, second: 27, millisecond: 192, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1940, month: 10, day: 14, hour: 3, minute: 30, second: 2, millisecond: 979, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 17,
    Value = new DateTime(year: 1991, month: 10, day: 16, hour: 16, minute: 25, second: 24, millisecond: 608, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 19,
    Value = new DateTime(year: 1937, month: 10, day: 19, hour: 12, minute: 6, second: 45, millisecond: 45, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 12,
    Value = new DateTime(year: 2012, month: 10, day: 18, hour: 21, minute: 1, second: 11, millisecond: 792, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1949, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 488, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1959, month: 10, day: 17, hour: 18, minute: 20, second: 52, millisecond: 479, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 25,
    Value = new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 54, millisecond: 754, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 34,
    Value = new DateTime(year: 1984, month: 10, day: 1, hour: 22, minute: 39, second: 12, millisecond: 736, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 13,
    Value = new DateTime(year: 2010, month: 10, day: 16, hour: 4, minute: 30, second: 55, millisecond: 543, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1954, month: 10, day: 14, hour: 22, minute: 4, second: 11, millisecond: 413, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1955, month: 10, day: 8, hour: 6, minute: 5, second: 52, millisecond: 514, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 41,
    Value = new DateTime(year: 1947, month: 10, day: 9, hour: 20, minute: 30, second: 2, millisecond: 312, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1984, month: 10, day: 11, hour: 22, minute: 30, second: 58, millisecond: 325, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 45,
    Value = new DateTime(year: 1985, month: 10, day: 6, hour: 2, minute: 4, second: 53, millisecond: 894, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 21,
    Value = new DateTime(year: 2002, month: 10, day: 7, hour: 20, minute: 30, second: 57, millisecond: 409, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1917, month: 10, day: 17, hour: 22, minute: 45, second: 42, millisecond: 683, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 2007, month: 10, day: 5, hour: 17, minute: 2, second: 27, millisecond: 520, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 53,
    Value = new DateTime(year: 1917, month: 10, day: 4, hour: 2, minute: 3, second: 54, millisecond: 814, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 59,
    Value = new DateTime(year: 1951, month: 10, day: 1, hour: 9, minute: 26, second: 57, millisecond: 385, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 22,
    Value = new DateTime(year: 2018, month: 10, day: 13, hour: 13, minute: 17, second: 23, millisecond: 333, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2016, month: 10, day: 13, hour: 19, minute: 29, second: 14, millisecond: 723, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 62,
    Value = new DateTime(year: 1989, month: 10, day: 9, hour: 17, minute: 57, second: 56, millisecond: 243, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1941, month: 10, day: 6, hour: 11, minute: 18, second: 16, millisecond: 928, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 68,
    Value = new DateTime(year: 2001, month: 10, day: 2, hour: 1, minute: 20, second: 16, millisecond: 399, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 23,
    Value = new DateTime(year: 1940, month: 10, day: 8, hour: 18, minute: 3, second: 12, millisecond: 462, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 74,
    Value = new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 54, second: 16, millisecond: 398, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 2007, month: 10, day: 5, hour: 9, minute: 7, second: 6, millisecond: 632, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 76,
    Value = new DateTime(year: 1945, month: 10, day: 2, hour: 20, minute: 58, second: 37, millisecond: 771, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 28,
    Value = new DateTime(year: 1945, month: 10, day: 17, hour: 6, minute: 21, second: 38, millisecond: 502, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1936, month: 10, day: 2, hour: 4, minute: 49, second: 1, millisecond: 281, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 81,
    Value = new DateTime(year: 2005, month: 10, day: 5, hour: 11, minute: 30, second: 55, millisecond: 834, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 86,
    Value = new DateTime(year: 2017, month: 10, day: 9, hour: 13, minute: 46, second: 31, millisecond: 955, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 37,
    Value = new DateTime(year: 1988, month: 10, day: 19, hour: 6, minute: 47, second: 24, millisecond: 47, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 2011, month: 10, day: 9, hour: 2, minute: 25, second: 15, millisecond: 781, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 88,
    Value = new DateTime(year: 1918, month: 10, day: 1, hour: 5, minute: 25, second: 25, millisecond: 28, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 89,
    Value = new DateTime(year: 1948, month: 10, day: 17, hour: 15, minute: 58, second: 49, millisecond: 985, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 40,
    Value = new DateTime(year: 1984, month: 10, day: 9, hour: 4, minute: 4, second: 45, millisecond: 636, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1929, month: 10, day: 9, hour: 11, minute: 53, second: 21, millisecond: 572, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 94,
    Value = new DateTime(year: 2003, month: 10, day: 13, hour: 9, minute: 52, second: 40, millisecond: 622, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1935, month: 10, day: 11, hour: 2, minute: 4, second: 35, millisecond: 219, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 103,
    Value = new DateTime(year: 1969, month: 10, day: 14, hour: 2, minute: 37, second: 22, millisecond: 485, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 45,
    Value = new DateTime(year: 2002, month: 10, day: 10, hour: 21, minute: 6, second: 46, millisecond: 465, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 34, second: 30, millisecond: 530, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 110,
    Value = new DateTime(year: 1956, month: 10, day: 15, hour: 10, minute: 13, second: 54, millisecond: 62, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1923, month: 10, day: 14, hour: 4, minute: 55, second: 8, millisecond: 843, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 119,
    Value = new DateTime(year: 2015, month: 10, day: 4, hour: 3, minute: 21, second: 4, millisecond: 407, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 49,
    Value = new DateTime(year: 1985, month: 10, day: 4, hour: 17, minute: 52, second: 15, millisecond: 87, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 126,
    Value = new DateTime(year: 1965, month: 10, day: 7, hour: 6, minute: 22, second: 53, millisecond: 198, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1920, month: 10, day: 2, hour: 14, minute: 26, second: 46, millisecond: 745, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 127,
    Value = new DateTime(year: 1938, month: 10, day: 19, hour: 8, minute: 58, second: 36, millisecond: 105, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 58,
    Value = new DateTime(year: 1917, month: 10, day: 7, hour: 21, minute: 26, second: 37, millisecond: 601, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 56, second: 11, millisecond: 623, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 133,
    Value = new DateTime(year: 1987, month: 10, day: 3, hour: 19, minute: 20, second: 17, millisecond: 365, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 138,
    Value = new DateTime(year: 1978, month: 10, day: 12, hour: 13, minute: 56, second: 29, millisecond: 294, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 67,
    Value = new DateTime(year: 1936, month: 10, day: 3, hour: 19, minute: 37, second: 5, millisecond: 464, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1966, month: 10, day: 10, hour: 18, minute: 9, second: 55, millisecond: 436, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 142,
    Value = new DateTime(year: 1920, month: 10, day: 11, hour: 21, minute: 8, second: 31, millisecond: 749, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 148,
    Value = new DateTime(year: 2014, month: 10, day: 15, hour: 16, minute: 17, second: 42, millisecond: 560, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 73,
    Value = new DateTime(year: 1953, month: 10, day: 10, hour: 11, minute: 26, second: 33, millisecond: 86, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1997, month: 10, day: 6, hour: 16, minute: 26, second: 30, millisecond: 68, kind: DateTimeKind.Local),
},
    NullableValue = null,
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(33)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(33))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(33)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(33),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime20mi_id", 
                methodParametrName: "datetimedatetime20mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models = await ((IDateTimeSingleTypedatetime2)this).SelectModelDynParAsync(connection, [parametr1]);
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

                var models =  ((IDateTimeSingleTypedatetime2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeSingleTypedatetime2)this).DynQuerySelectModel(connection,  query, 0);
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).SelectModelAsync(connection, 0);
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
                var models =  ((IDateTimeSingleTypedatetime2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[7], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[8], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[9], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[10], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[11], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[18],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[19],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[20],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[21],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[22],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[3], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[4], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[5], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[6], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[7], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[8], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[9], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[10], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[11], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[18],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[19],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[20],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[21],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[22],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[23],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[24],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[25],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[5], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[6], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[7], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[8], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[9], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[10], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[11], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[18],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[19],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[20],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[21],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[22],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[23],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
DateTimedatetime20M.AssertModel(models[0],_testData[15], false);DateTimedatetime20M.AssertModel(models[1],_testData[16], false);DateTimedatetime20M.AssertModel(models[2],_testData[17], false);DateTimedatetime20M.AssertModel(models[3],_testData[18], false);DateTimedatetime20M.AssertModel(models[4],_testData[19], false);DateTimedatetime20M.AssertModel(models[5],_testData[20], false);DateTimedatetime20M.AssertModel(models[6],_testData[21], false);DateTimedatetime20M.AssertModel(models[7],_testData[22], false);DateTimedatetime20M.AssertModel(models[8],_testData[23], false);DateTimedatetime20M.AssertModel(models[9],_testData[24], false);DateTimedatetime20M.AssertModel(models[10],_testData[25], false);DateTimedatetime20M.AssertModel(models[11],_testData[26], false);DateTimedatetime20M.AssertModel(models[12],_testData[27], false);DateTimedatetime20M.AssertModel(models[13],_testData[28], false);DateTimedatetime20M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
DateTimedatetime20M.AssertModel(models[0],_testData[10], false);DateTimedatetime20M.AssertModel(models[1],_testData[11], false);DateTimedatetime20M.AssertModel(models[2],_testData[12], false);DateTimedatetime20M.AssertModel(models[3],_testData[13], false);DateTimedatetime20M.AssertModel(models[4],_testData[14], false);DateTimedatetime20M.AssertModel(models[5],_testData[15], false);DateTimedatetime20M.AssertModel(models[6],_testData[16], false);DateTimedatetime20M.AssertModel(models[7],_testData[17], false);DateTimedatetime20M.AssertModel(models[8],_testData[18], false);DateTimedatetime20M.AssertModel(models[9],_testData[19], false);DateTimedatetime20M.AssertModel(models[10],_testData[20], false);DateTimedatetime20M.AssertModel(models[11],_testData[21], false);DateTimedatetime20M.AssertModel(models[12],_testData[22], false);DateTimedatetime20M.AssertModel(models[13],_testData[23], false);DateTimedatetime20M.AssertModel(models[14],_testData[24], false);DateTimedatetime20M.AssertModel(models[15],_testData[25], false);DateTimedatetime20M.AssertModel(models[16],_testData[26], false);DateTimedatetime20M.AssertModel(models[17],_testData[27], false);DateTimedatetime20M.AssertModel(models[18],_testData[28], false);DateTimedatetime20M.AssertModel(models[19],_testData[29], false);
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

                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DateTimedatetime20M.AssertModel(models[0],_testData[2], false);DateTimedatetime20M.AssertModel(models[1],_testData[3], false);DateTimedatetime20M.AssertModel(models[2],_testData[4], false);DateTimedatetime20M.AssertModel(models[3],_testData[5], false);DateTimedatetime20M.AssertModel(models[4],_testData[6], false);DateTimedatetime20M.AssertModel(models[5],_testData[7], false);DateTimedatetime20M.AssertModel(models[6],_testData[8], false);DateTimedatetime20M.AssertModel(models[7],_testData[9], false);DateTimedatetime20M.AssertModel(models[8],_testData[10], false);DateTimedatetime20M.AssertModel(models[9],_testData[11], false);DateTimedatetime20M.AssertModel(models[10],_testData[12], false);DateTimedatetime20M.AssertModel(models[11],_testData[13], false);DateTimedatetime20M.AssertModel(models[12],_testData[14], false);DateTimedatetime20M.AssertModel(models[13],_testData[15], false);DateTimedatetime20M.AssertModel(models[14],_testData[16], false);DateTimedatetime20M.AssertModel(models[15],_testData[17], false);DateTimedatetime20M.AssertModel(models[16],_testData[18], false);DateTimedatetime20M.AssertModel(models[17],_testData[19], false);DateTimedatetime20M.AssertModel(models[18],_testData[20], false);DateTimedatetime20M.AssertModel(models[19],_testData[21], false);DateTimedatetime20M.AssertModel(models[20],_testData[22], false);DateTimedatetime20M.AssertModel(models[21],_testData[23], false);DateTimedatetime20M.AssertModel(models[22],_testData[24], false);DateTimedatetime20M.AssertModel(models[23],_testData[25], false);DateTimedatetime20M.AssertModel(models[24],_testData[26], false);DateTimedatetime20M.AssertModel(models[25],_testData[27], false);DateTimedatetime20M.AssertModel(models[26],_testData[28], false);DateTimedatetime20M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DateTimedatetime20M.AssertModel(models[0],_testData[11], false);DateTimedatetime20M.AssertModel(models[1],_testData[12], false);DateTimedatetime20M.AssertModel(models[2],_testData[13], false);DateTimedatetime20M.AssertModel(models[3],_testData[14], false);DateTimedatetime20M.AssertModel(models[4],_testData[15], false);DateTimedatetime20M.AssertModel(models[5],_testData[16], false);DateTimedatetime20M.AssertModel(models[6],_testData[17], false);DateTimedatetime20M.AssertModel(models[7],_testData[18], false);DateTimedatetime20M.AssertModel(models[8],_testData[19], false);DateTimedatetime20M.AssertModel(models[9],_testData[20], false);DateTimedatetime20M.AssertModel(models[10],_testData[21], false);DateTimedatetime20M.AssertModel(models[11],_testData[22], false);DateTimedatetime20M.AssertModel(models[12],_testData[23], false);DateTimedatetime20M.AssertModel(models[13],_testData[24], false);DateTimedatetime20M.AssertModel(models[14],_testData[25], false);DateTimedatetime20M.AssertModel(models[15],_testData[26], false);DateTimedatetime20M.AssertModel(models[16],_testData[27], false);DateTimedatetime20M.AssertModel(models[17],_testData[28], false);DateTimedatetime20M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateTimedatetime20M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[4], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[5], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[6], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[7], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[8], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[9], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[10], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[11], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[18],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[19],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[20],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[21],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[22],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[23],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[24],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[25],_testData[29], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDateTimedatetime20M.AssertModel(models[0],_testData[9], false);FlatDateTimedatetime20M.AssertModel(models[1],_testData[10], false);FlatDateTimedatetime20M.AssertModel(models[2],_testData[11], false);FlatDateTimedatetime20M.AssertModel(models[3],_testData[12], false);FlatDateTimedatetime20M.AssertModel(models[4],_testData[13], false);FlatDateTimedatetime20M.AssertModel(models[5],_testData[14], false);FlatDateTimedatetime20M.AssertModel(models[6],_testData[15], false);FlatDateTimedatetime20M.AssertModel(models[7],_testData[16], false);FlatDateTimedatetime20M.AssertModel(models[8],_testData[17], false);FlatDateTimedatetime20M.AssertModel(models[9],_testData[18], false);FlatDateTimedatetime20M.AssertModel(models[10],_testData[19], false);FlatDateTimedatetime20M.AssertModel(models[11],_testData[20], false);FlatDateTimedatetime20M.AssertModel(models[12],_testData[21], false);FlatDateTimedatetime20M.AssertModel(models[13],_testData[22], false);FlatDateTimedatetime20M.AssertModel(models[14],_testData[23], false);FlatDateTimedatetime20M.AssertModel(models[15],_testData[24], false);FlatDateTimedatetime20M.AssertModel(models[16],_testData[25], false);FlatDateTimedatetime20M.AssertModel(models[17],_testData[26], false);FlatDateTimedatetime20M.AssertModel(models[18],_testData[27], false);FlatDateTimedatetime20M.AssertModel(models[19],_testData[28], false);FlatDateTimedatetime20M.AssertModel(models[20],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelBatchAsync(connection, 4, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
DateTimedatetime20M.AssertModel(models[0],_testData[1], false);DateTimedatetime20M.AssertModel(models[1],_testData[2], false);DateTimedatetime20M.AssertModel(models[2],_testData[3], false);DateTimedatetime20M.AssertModel(models[3],_testData[4], false);DateTimedatetime20M.AssertModel(models[4],_testData[5], false);DateTimedatetime20M.AssertModel(models[5],_testData[6], false);DateTimedatetime20M.AssertModel(models[6],_testData[7], false);DateTimedatetime20M.AssertModel(models[7],_testData[8], false);DateTimedatetime20M.AssertModel(models[8],_testData[9], false);DateTimedatetime20M.AssertModel(models[9],_testData[10], false);DateTimedatetime20M.AssertModel(models[10],_testData[11], false);DateTimedatetime20M.AssertModel(models[11],_testData[12], false);DateTimedatetime20M.AssertModel(models[12],_testData[13], false);DateTimedatetime20M.AssertModel(models[13],_testData[14], false);DateTimedatetime20M.AssertModel(models[14],_testData[15], false);DateTimedatetime20M.AssertModel(models[15],_testData[16], false);DateTimedatetime20M.AssertModel(models[16],_testData[17], false);DateTimedatetime20M.AssertModel(models[17],_testData[18], false);DateTimedatetime20M.AssertModel(models[18],_testData[19], false);DateTimedatetime20M.AssertModel(models[19],_testData[20], false);DateTimedatetime20M.AssertModel(models[20],_testData[21], false);DateTimedatetime20M.AssertModel(models[21],_testData[22], false);DateTimedatetime20M.AssertModel(models[22],_testData[23], false);DateTimedatetime20M.AssertModel(models[23],_testData[24], false);DateTimedatetime20M.AssertModel(models[24],_testData[25], false);DateTimedatetime20M.AssertModel(models[25],_testData[26], false);DateTimedatetime20M.AssertModel(models[26],_testData[27], false);DateTimedatetime20M.AssertModel(models[27],_testData[28], false);DateTimedatetime20M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
DateTimedatetime20M.AssertModel(models[0],_testData[21], false);DateTimedatetime20M.AssertModel(models[1],_testData[22], false);DateTimedatetime20M.AssertModel(models[2],_testData[23], false);DateTimedatetime20M.AssertModel(models[3],_testData[24], false);DateTimedatetime20M.AssertModel(models[4],_testData[25], false);DateTimedatetime20M.AssertModel(models[5],_testData[26], false);DateTimedatetime20M.AssertModel(models[6],_testData[27], false);DateTimedatetime20M.AssertModel(models[7],_testData[28], false);DateTimedatetime20M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DateTimedatetime20M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelBatch(connection, 62, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
DateTimedatetime20M.AssertModel(models[0],_testData[13], false);DateTimedatetime20M.AssertModel(models[1],_testData[14], false);DateTimedatetime20M.AssertModel(models[2],_testData[15], false);DateTimedatetime20M.AssertModel(models[3],_testData[16], false);DateTimedatetime20M.AssertModel(models[4],_testData[17], false);DateTimedatetime20M.AssertModel(models[5],_testData[18], false);DateTimedatetime20M.AssertModel(models[6],_testData[19], false);DateTimedatetime20M.AssertModel(models[7],_testData[20], false);DateTimedatetime20M.AssertModel(models[8],_testData[21], false);DateTimedatetime20M.AssertModel(models[9],_testData[22], false);DateTimedatetime20M.AssertModel(models[10],_testData[23], false);DateTimedatetime20M.AssertModel(models[11],_testData[24], false);DateTimedatetime20M.AssertModel(models[12],_testData[25], false);DateTimedatetime20M.AssertModel(models[13],_testData[26], false);DateTimedatetime20M.AssertModel(models[14],_testData[27], false);DateTimedatetime20M.AssertModel(models[15],_testData[28], false);DateTimedatetime20M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
DateTimedatetime20M.AssertModel(models[0],_testData[16], false);DateTimedatetime20M.AssertModel(models[1],_testData[17], false);DateTimedatetime20M.AssertModel(models[2],_testData[18], false);DateTimedatetime20M.AssertModel(models[3],_testData[19], false);DateTimedatetime20M.AssertModel(models[4],_testData[20], false);DateTimedatetime20M.AssertModel(models[5],_testData[21], false);DateTimedatetime20M.AssertModel(models[6],_testData[22], false);DateTimedatetime20M.AssertModel(models[7],_testData[23], false);DateTimedatetime20M.AssertModel(models[8],_testData[24], false);DateTimedatetime20M.AssertModel(models[9],_testData[25], false);DateTimedatetime20M.AssertModel(models[10],_testData[26], false);DateTimedatetime20M.AssertModel(models[11],_testData[27], false);DateTimedatetime20M.AssertModel(models[12],_testData[28], false);DateTimedatetime20M.AssertModel(models[13],_testData[29], false);
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
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
DateTimedatetime20M.AssertModel(models[0],_testData[1], false);DateTimedatetime20M.AssertModel(models[1],_testData[2], false);DateTimedatetime20M.AssertModel(models[2],_testData[3], false);DateTimedatetime20M.AssertModel(models[3],_testData[4], false);DateTimedatetime20M.AssertModel(models[4],_testData[5], false);DateTimedatetime20M.AssertModel(models[5],_testData[6], false);DateTimedatetime20M.AssertModel(models[6],_testData[7], false);DateTimedatetime20M.AssertModel(models[7],_testData[8], false);DateTimedatetime20M.AssertModel(models[8],_testData[9], false);DateTimedatetime20M.AssertModel(models[9],_testData[10], false);DateTimedatetime20M.AssertModel(models[10],_testData[11], false);DateTimedatetime20M.AssertModel(models[11],_testData[12], false);DateTimedatetime20M.AssertModel(models[12],_testData[13], false);DateTimedatetime20M.AssertModel(models[13],_testData[14], false);DateTimedatetime20M.AssertModel(models[14],_testData[15], false);DateTimedatetime20M.AssertModel(models[15],_testData[16], false);DateTimedatetime20M.AssertModel(models[16],_testData[17], false);DateTimedatetime20M.AssertModel(models[17],_testData[18], false);DateTimedatetime20M.AssertModel(models[18],_testData[19], false);DateTimedatetime20M.AssertModel(models[19],_testData[20], false);DateTimedatetime20M.AssertModel(models[20],_testData[21], false);DateTimedatetime20M.AssertModel(models[21],_testData[22], false);DateTimedatetime20M.AssertModel(models[22],_testData[23], false);DateTimedatetime20M.AssertModel(models[23],_testData[24], false);DateTimedatetime20M.AssertModel(models[24],_testData[25], false);DateTimedatetime20M.AssertModel(models[25],_testData[26], false);DateTimedatetime20M.AssertModel(models[26],_testData[27], false);DateTimedatetime20M.AssertModel(models[27],_testData[28], false);DateTimedatetime20M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DateTimedatetime20M.AssertModel(models[0],_testData[6], false);DateTimedatetime20M.AssertModel(models[1],_testData[7], false);DateTimedatetime20M.AssertModel(models[2],_testData[8], false);DateTimedatetime20M.AssertModel(models[3],_testData[9], false);DateTimedatetime20M.AssertModel(models[4],_testData[10], false);DateTimedatetime20M.AssertModel(models[5],_testData[11], false);DateTimedatetime20M.AssertModel(models[6],_testData[12], false);DateTimedatetime20M.AssertModel(models[7],_testData[13], false);DateTimedatetime20M.AssertModel(models[8],_testData[14], false);DateTimedatetime20M.AssertModel(models[9],_testData[15], false);DateTimedatetime20M.AssertModel(models[10],_testData[16], false);DateTimedatetime20M.AssertModel(models[11],_testData[17], false);DateTimedatetime20M.AssertModel(models[12],_testData[18], false);DateTimedatetime20M.AssertModel(models[13],_testData[19], false);DateTimedatetime20M.AssertModel(models[14],_testData[20], false);DateTimedatetime20M.AssertModel(models[15],_testData[21], false);DateTimedatetime20M.AssertModel(models[16],_testData[22], false);DateTimedatetime20M.AssertModel(models[17],_testData[23], false);DateTimedatetime20M.AssertModel(models[18],_testData[24], false);DateTimedatetime20M.AssertModel(models[19],_testData[25], false);DateTimedatetime20M.AssertModel(models[20],_testData[26], false);DateTimedatetime20M.AssertModel(models[21],_testData[27], false);DateTimedatetime20M.AssertModel(models[22],_testData[28], false);DateTimedatetime20M.AssertModel(models[23],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 22, minute: 39, second: 5, millisecond: 590, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 13, hour: 9, minute: 38, second: 24, millisecond: 757, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 7, hour: 19, minute: 48, second: 46, millisecond: 379, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 18, hour: 15, minute: 52, second: 55, millisecond: 857, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 17, hour: 1, minute: 51, second: 43, millisecond: 351, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 8, hour: 19, minute: 20, second: 18, millisecond: 991, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 3, minute: 20, second: 35, millisecond: 358, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 15, hour: 14, minute: 6, second: 31, millisecond: 591, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 4, hour: 11, minute: 13, second: 27, millisecond: 192, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 14, hour: 3, minute: 30, second: 2, millisecond: 979, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 16, hour: 16, minute: 25, second: 24, millisecond: 608, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 19, hour: 12, minute: 6, second: 45, millisecond: 45, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 18, hour: 21, minute: 1, second: 11, millisecond: 792, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 488, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 17, hour: 18, minute: 20, second: 52, millisecond: 479, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 54, millisecond: 754, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 22, minute: 39, second: 12, millisecond: 736, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 16, hour: 4, minute: 30, second: 55, millisecond: 543, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 14, hour: 22, minute: 4, second: 11, millisecond: 413, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 8, hour: 6, minute: 5, second: 52, millisecond: 514, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 20, minute: 30, second: 2, millisecond: 312, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 11, hour: 22, minute: 30, second: 58, millisecond: 325, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 6, hour: 2, minute: 4, second: 53, millisecond: 894, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 7, hour: 20, minute: 30, second: 57, millisecond: 409, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 17, hour: 22, minute: 45, second: 42, millisecond: 683, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 17, minute: 2, second: 27, millisecond: 520, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 4, hour: 2, minute: 3, second: 54, millisecond: 814, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 1, hour: 9, minute: 26, second: 57, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 13, hour: 13, minute: 17, second: 23, millisecond: 333, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 13, hour: 19, minute: 29, second: 14, millisecond: 723, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 9, hour: 17, minute: 57, second: 56, millisecond: 243, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 11, minute: 18, second: 16, millisecond: 928, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 1, minute: 20, second: 16, millisecond: 399, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 18, minute: 3, second: 12, millisecond: 462, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 54, second: 16, millisecond: 398, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 9, minute: 7, second: 6, millisecond: 632, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 2, hour: 20, minute: 58, second: 37, millisecond: 771, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 17, hour: 6, minute: 21, second: 38, millisecond: 502, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 2, hour: 4, minute: 49, second: 1, millisecond: 281, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 5, hour: 11, minute: 30, second: 55, millisecond: 834, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 9, hour: 13, minute: 46, second: 31, millisecond: 955, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 19, hour: 6, minute: 47, second: 24, millisecond: 47, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 9, hour: 2, minute: 25, second: 15, millisecond: 781, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 1, hour: 5, minute: 25, second: 25, millisecond: 28, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 17, hour: 15, minute: 58, second: 49, millisecond: 985, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 9, hour: 4, minute: 4, second: 45, millisecond: 636, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 9, hour: 11, minute: 53, second: 21, millisecond: 572, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 13, hour: 9, minute: 52, second: 40, millisecond: 622, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 11, hour: 2, minute: 4, second: 35, millisecond: 219, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 14, hour: 2, minute: 37, second: 22, millisecond: 485, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 10, hour: 21, minute: 6, second: 46, millisecond: 465, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 34, second: 30, millisecond: 530, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 15, hour: 10, minute: 13, second: 54, millisecond: 62, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 14, hour: 4, minute: 55, second: 8, millisecond: 843, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 4, hour: 3, minute: 21, second: 4, millisecond: 407, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 4, hour: 17, minute: 52, second: 15, millisecond: 87, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 7, hour: 6, minute: 22, second: 53, millisecond: 198, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 2, hour: 14, minute: 26, second: 46, millisecond: 745, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 19, hour: 8, minute: 58, second: 36, millisecond: 105, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 7, hour: 21, minute: 26, second: 37, millisecond: 601, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 56, second: 11, millisecond: 623, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 3, hour: 19, minute: 20, second: 17, millisecond: 365, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 12, hour: 13, minute: 56, second: 29, millisecond: 294, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 3, hour: 19, minute: 37, second: 5, millisecond: 464, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 10, hour: 18, minute: 9, second: 55, millisecond: 436, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 11, hour: 21, minute: 8, second: 31, millisecond: 749, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 15, hour: 16, minute: 17, second: 42, millisecond: 560, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 10, hour: 11, minute: 26, second: 33, millisecond: 86, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 6, hour: 16, minute: 26, second: 30, millisecond: 68, kind: DateTimeKind.Local))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 22, minute: 39, second: 5, millisecond: 590, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 13, hour: 9, minute: 38, second: 24, millisecond: 757, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 7, hour: 19, minute: 48, second: 46, millisecond: 379, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 18, hour: 15, minute: 52, second: 55, millisecond: 857, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 17, hour: 1, minute: 51, second: 43, millisecond: 351, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 8, hour: 19, minute: 20, second: 18, millisecond: 991, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 3, minute: 20, second: 35, millisecond: 358, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 15, hour: 14, minute: 6, second: 31, millisecond: 591, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 4, hour: 11, minute: 13, second: 27, millisecond: 192, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 14, hour: 3, minute: 30, second: 2, millisecond: 979, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 16, hour: 16, minute: 25, second: 24, millisecond: 608, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 19, hour: 12, minute: 6, second: 45, millisecond: 45, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 18, hour: 21, minute: 1, second: 11, millisecond: 792, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 15, hour: 21, minute: 15, second: 23, millisecond: 488, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 17, hour: 18, minute: 20, second: 52, millisecond: 479, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 19, hour: 18, minute: 41, second: 54, millisecond: 754, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 1, hour: 22, minute: 39, second: 12, millisecond: 736, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 16, hour: 4, minute: 30, second: 55, millisecond: 543, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 14, hour: 22, minute: 4, second: 11, millisecond: 413, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 8, hour: 6, minute: 5, second: 52, millisecond: 514, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 9, hour: 20, minute: 30, second: 2, millisecond: 312, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 11, hour: 22, minute: 30, second: 58, millisecond: 325, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 6, hour: 2, minute: 4, second: 53, millisecond: 894, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 7, hour: 20, minute: 30, second: 57, millisecond: 409, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 17, hour: 22, minute: 45, second: 42, millisecond: 683, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 17, minute: 2, second: 27, millisecond: 520, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 4, hour: 2, minute: 3, second: 54, millisecond: 814, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1951, month: 10, day: 1, hour: 9, minute: 26, second: 57, millisecond: 385, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 13, hour: 13, minute: 17, second: 23, millisecond: 333, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 13, hour: 19, minute: 29, second: 14, millisecond: 723, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 9, hour: 17, minute: 57, second: 56, millisecond: 243, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 11, minute: 18, second: 16, millisecond: 928, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 2, hour: 1, minute: 20, second: 16, millisecond: 399, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 8, hour: 18, minute: 3, second: 12, millisecond: 462, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 54, second: 16, millisecond: 398, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 5, hour: 9, minute: 7, second: 6, millisecond: 632, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 2, hour: 20, minute: 58, second: 37, millisecond: 771, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 17, hour: 6, minute: 21, second: 38, millisecond: 502, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 2, hour: 4, minute: 49, second: 1, millisecond: 281, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 5, hour: 11, minute: 30, second: 55, millisecond: 834, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 9, hour: 13, minute: 46, second: 31, millisecond: 955, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 19, hour: 6, minute: 47, second: 24, millisecond: 47, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 9, hour: 2, minute: 25, second: 15, millisecond: 781, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 1, hour: 5, minute: 25, second: 25, millisecond: 28, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 17, hour: 15, minute: 58, second: 49, millisecond: 985, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 9, hour: 4, minute: 4, second: 45, millisecond: 636, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 9, hour: 11, minute: 53, second: 21, millisecond: 572, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 13, hour: 9, minute: 52, second: 40, millisecond: 622, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 11, hour: 2, minute: 4, second: 35, millisecond: 219, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 14, hour: 2, minute: 37, second: 22, millisecond: 485, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 10, hour: 21, minute: 6, second: 46, millisecond: 465, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 8, hour: 8, minute: 34, second: 30, millisecond: 530, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 15, hour: 10, minute: 13, second: 54, millisecond: 62, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 14, hour: 4, minute: 55, second: 8, millisecond: 843, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 4, hour: 3, minute: 21, second: 4, millisecond: 407, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 4, hour: 17, minute: 52, second: 15, millisecond: 87, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 7, hour: 6, minute: 22, second: 53, millisecond: 198, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 2, hour: 14, minute: 26, second: 46, millisecond: 745, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 19, hour: 8, minute: 58, second: 36, millisecond: 105, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 7, hour: 21, minute: 26, second: 37, millisecond: 601, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 19, hour: 14, minute: 56, second: 11, millisecond: 623, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 3, hour: 19, minute: 20, second: 17, millisecond: 365, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 12, hour: 13, minute: 56, second: 29, millisecond: 294, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 3, hour: 19, minute: 37, second: 5, millisecond: 464, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 10, hour: 18, minute: 9, second: 55, millisecond: 436, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 11, hour: 21, minute: 8, second: 31, millisecond: 749, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 15, hour: 16, minute: 17, second: 42, millisecond: 560, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 10, hour: 11, minute: 26, second: 33, millisecond: 86, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 6, hour: 16, minute: 26, second: 30, millisecond: 68, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


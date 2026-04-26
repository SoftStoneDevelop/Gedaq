

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
    Id = 3,
    Value = new DateTime(year: 1982, month: 10, day: 10, hour: 13, minute: 54, second: 7, millisecond: 236, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 8,
    Value = new DateTime(year: 2000, month: 10, day: 3, hour: 2, minute: 3, second: 9, millisecond: 345, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 6,
    Value = new DateTime(year: 2018, month: 10, day: 9, hour: 1, minute: 47, second: 14, millisecond: 488, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 12,
    Value = new DateTime(year: 1992, month: 10, day: 19, hour: 6, minute: 52, second: 17, millisecond: 472, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1985, month: 10, day: 12, hour: 12, minute: 21, second: 46, millisecond: 210, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 17,
    Value = new DateTime(year: 1936, month: 10, day: 6, hour: 11, minute: 48, second: 10, millisecond: 149, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 10,
    Value = new DateTime(year: 1958, month: 10, day: 2, hour: 21, minute: 43, second: 55, millisecond: 274, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1927, month: 10, day: 4, hour: 14, minute: 24, second: 15, millisecond: 349, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 25,
    Value = new DateTime(year: 1927, month: 10, day: 1, hour: 20, minute: 8, second: 1, millisecond: 236, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 28,
    Value = new DateTime(year: 1948, month: 10, day: 18, hour: 1, minute: 3, second: 43, millisecond: 561, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 13,
    Value = new DateTime(year: 1999, month: 10, day: 6, hour: 12, minute: 17, second: 6, millisecond: 173, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 29,
    Value = new DateTime(year: 1960, month: 10, day: 12, hour: 3, minute: 53, second: 33, millisecond: 494, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 37,
    Value = new DateTime(year: 2013, month: 10, day: 5, hour: 14, minute: 14, second: 55, millisecond: 38, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 19,
    Value = new DateTime(year: 1957, month: 10, day: 7, hour: 18, minute: 33, second: 13, millisecond: 648, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1940, month: 10, day: 10, hour: 21, minute: 53, second: 26, millisecond: 386, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 18, minute: 54, second: 14, millisecond: 436, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 44,
    Value = new DateTime(year: 1968, month: 10, day: 19, hour: 19, minute: 10, second: 57, millisecond: 233, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 48,
    Value = new DateTime(year: 1938, month: 10, day: 11, hour: 17, minute: 41, second: 49, millisecond: 198, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 25,
    Value = new DateTime(year: 2013, month: 10, day: 14, hour: 21, minute: 33, second: 29, millisecond: 279, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 52,
    Value = new DateTime(year: 1962, month: 10, day: 9, hour: 18, minute: 19, second: 55, millisecond: 794, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1954, month: 10, day: 4, hour: 7, minute: 6, second: 39, millisecond: 709, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 53,
    Value = new DateTime(year: 1987, month: 10, day: 15, hour: 5, minute: 49, second: 22, millisecond: 834, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 34,
    Value = new DateTime(year: 1963, month: 10, day: 4, hour: 1, minute: 7, second: 44, millisecond: 106, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 7, minute: 33, second: 39, millisecond: 134, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1954, month: 10, day: 10, hour: 2, minute: 39, second: 9, millisecond: 825, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 56,
    Value = new DateTime(year: 1952, month: 10, day: 5, hour: 12, minute: 4, second: 13, millisecond: 865, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 62,
    Value = new DateTime(year: 2011, month: 10, day: 16, hour: 1, minute: 16, second: 49, millisecond: 887, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 38,
    Value = new DateTime(year: 1944, month: 10, day: 12, hour: 20, minute: 9, second: 25, millisecond: 939, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1930, month: 10, day: 10, hour: 7, minute: 51, second: 53, millisecond: 69, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 67,
    Value = new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 54, second: 58, millisecond: 710, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1926, month: 10, day: 10, hour: 12, minute: 21, second: 35, millisecond: 110, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 75,
    Value = new DateTime(year: 1973, month: 10, day: 18, hour: 4, minute: 16, second: 42, millisecond: 884, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 47,
    Value = new DateTime(year: 1979, month: 10, day: 19, hour: 13, minute: 27, second: 18, millisecond: 995, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1960, month: 10, day: 12, hour: 16, minute: 19, second: 2, millisecond: 500, kind: DateTimeKind.Local),
},
    NullableValue = new DateTime(year: 1947, month: 10, day: 10, hour: 8, minute: 28, second: 28, millisecond: 321, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 78,
    Value = new DateTime(year: 1941, month: 10, day: 2, hour: 17, minute: 49, second: 17, millisecond: 725, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 84,
    Value = new DateTime(year: 2001, month: 10, day: 11, hour: 10, minute: 11, second: 3, millisecond: 410, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 52,
    Value = new DateTime(year: 2002, month: 10, day: 12, hour: 18, minute: 17, second: 39, millisecond: 193, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1920, month: 10, day: 5, hour: 8, minute: 28, second: 25, millisecond: 64, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 91,
    Value = new DateTime(year: 1992, month: 10, day: 14, hour: 6, minute: 51, second: 48, millisecond: 209, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 43, second: 24, millisecond: 420, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 99,
    Value = new DateTime(year: 1955, month: 10, day: 17, hour: 5, minute: 31, second: 29, millisecond: 552, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 60,
    Value = new DateTime(year: 2009, month: 10, day: 13, hour: 18, minute: 33, second: 18, millisecond: 792, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1973, month: 10, day: 17, hour: 1, minute: 27, second: 25, millisecond: 185, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 101,
    Value = new DateTime(year: 1990, month: 10, day: 17, hour: 16, minute: 15, second: 55, millisecond: 705, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1958, month: 10, day: 12, hour: 7, minute: 17, second: 54, millisecond: 121, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 107,
    Value = new DateTime(year: 1942, month: 10, day: 14, hour: 21, minute: 29, second: 10, millisecond: 514, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 66,
    Value = new DateTime(year: 1947, month: 10, day: 11, hour: 3, minute: 2, second: 25, millisecond: 776, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 110,
    Value = new DateTime(year: 2006, month: 10, day: 18, hour: 7, minute: 50, second: 33, millisecond: 53, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 113,
    Value = new DateTime(year: 1975, month: 10, day: 12, hour: 11, minute: 37, second: 27, millisecond: 522, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 73,
    Value = new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 1, second: 23, millisecond: 24, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1955, month: 10, day: 10, hour: 15, minute: 26, second: 12, millisecond: 430, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 117,
    Value = new DateTime(year: 2009, month: 10, day: 8, hour: 22, minute: 57, second: 29, millisecond: 39, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = new DateTime(year: 1921, month: 10, day: 14, hour: 11, minute: 7, second: 34, millisecond: 451, kind: DateTimeKind.Local),
},
            new DateTimedatetime20M
{
    Id = 120,
    Value = new DateTime(year: 1962, month: 10, day: 19, hour: 9, minute: 37, second: 31, millisecond: 770, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 75,
    Value = new DateTime(year: 1985, month: 10, day: 19, hour: 10, minute: 30, second: 20, millisecond: 778, kind: DateTimeKind.Local),
    NullableValue = new DateTime(year: 1983, month: 10, day: 17, hour: 22, minute: 11, second: 55, millisecond: 512, kind: DateTimeKind.Local),
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 127,
    Value = new DateTime(year: 1925, month: 10, day: 14, hour: 2, minute: 31, second: 44, millisecond: 438, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 136,
    Value = new DateTime(year: 1920, month: 10, day: 16, hour: 8, minute: 14, second: 40, millisecond: 445, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 76,
    Value = new DateTime(year: 1945, month: 10, day: 14, hour: 19, minute: 9, second: 16, millisecond: 375, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 140,
    Value = new DateTime(year: 1917, month: 10, day: 9, hour: 7, minute: 26, second: 16, millisecond: 912, kind: DateTimeKind.Local),
    ModelInner = null,
    NullableValue = null,
},
            new DateTimedatetime20M
{
    Id = 149,
    Value = new DateTime(year: 1977, month: 10, day: 13, hour: 19, minute: 37, second: 51, millisecond: 669, kind: DateTimeKind.Local),
    ModelInner = new DateTimedatetime20MI
{
    Id = 83,
    Value = new DateTime(year: 2019, month: 10, day: 15, hour: 19, minute: 42, second: 23, millisecond: 744, kind: DateTimeKind.Local),
    NullableValue = null,
},
    NullableValue = new DateTime(year: 1999, month: 10, day: 14, hour: 10, minute: 33, second: 33, millisecond: 493, kind: DateTimeKind.Local),
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
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
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[25],_testData[30], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[26],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[16],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[16],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[17],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[18],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[19],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[20],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[21],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[22],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[28],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimedatetime20M.AssertModel(models[0],_testData[7], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[8], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[9], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[10], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[11], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[12], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[13], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[16],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[17],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[18],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[19],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[20],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[21],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateTimedatetime20M.AssertModel(models[0],_testData[7], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[8], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[9], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[10], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[11], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[12], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[13], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[16],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[17],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[18],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[19],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[20],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[21],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DateTimedatetime20M.AssertModel(models[0],_testData[5], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[6], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[7], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[8], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[9], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[10], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[11], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[12], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[13], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[16],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[17],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[18],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[19],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[20],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[21],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[22],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[23],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateTimedatetime20M.AssertModel(models[0],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[30], false);
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[29], false);
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
                await ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDateTimedatetime20M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(models[5],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(models[6],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(models[7],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(models[8],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(models[9],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(models[10],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(models[11],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(models[12],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(models[13],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(models[14],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[15],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[16],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[17],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDateTimedatetime20M.AssertModel(models[0],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(models[1],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(models[2],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(models[3],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(models[4],_testData[29], false);
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
                 ((IDateTimeSingleTypedatetime2)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDateTimedatetime20M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDateTimedatetime20M.AssertModel(secondItems2[21],_testData[30], false);
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
                foreach(var batchResult in await ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 117))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateTimedatetime20M.AssertModel(models[0],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[29], false);
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
                foreach(var batchResult in  ((IDateTimeSingleTypedatetime2)this).DbConnectionSTSelectModelBatch(connection, 56, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateTimedatetime20M.AssertModel(models[0],_testData[13], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[14], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[15], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[14],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[15],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DateTimedatetime20M.AssertModel(models[0],_testData[16], false);
                        DateTimedatetime20M.AssertModel(models[1],_testData[17], false);
                        DateTimedatetime20M.AssertModel(models[2],_testData[18], false);
                        DateTimedatetime20M.AssertModel(models[3],_testData[19], false);
                        DateTimedatetime20M.AssertModel(models[4],_testData[20], false);
                        DateTimedatetime20M.AssertModel(models[5],_testData[21], false);
                        DateTimedatetime20M.AssertModel(models[6],_testData[22], false);
                        DateTimedatetime20M.AssertModel(models[7],_testData[23], false);
                        DateTimedatetime20M.AssertModel(models[8],_testData[24], false);
                        DateTimedatetime20M.AssertModel(models[9],_testData[25], false);
                        DateTimedatetime20M.AssertModel(models[10],_testData[26], false);
                        DateTimedatetime20M.AssertModel(models[11],_testData[27], false);
                        DateTimedatetime20M.AssertModel(models[12],_testData[28], false);
                        DateTimedatetime20M.AssertModel(models[13],_testData[29], false);
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
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
DateTimedatetime20M.AssertModel(models[0],_testData[10], false);DateTimedatetime20M.AssertModel(models[1],_testData[11], false);DateTimedatetime20M.AssertModel(models[2],_testData[12], false);DateTimedatetime20M.AssertModel(models[3],_testData[13], false);DateTimedatetime20M.AssertModel(models[4],_testData[14], false);DateTimedatetime20M.AssertModel(models[5],_testData[15], false);DateTimedatetime20M.AssertModel(models[6],_testData[16], false);DateTimedatetime20M.AssertModel(models[7],_testData[17], false);DateTimedatetime20M.AssertModel(models[8],_testData[18], false);DateTimedatetime20M.AssertModel(models[9],_testData[19], false);DateTimedatetime20M.AssertModel(models[10],_testData[20], false);DateTimedatetime20M.AssertModel(models[11],_testData[21], false);DateTimedatetime20M.AssertModel(models[12],_testData[22], false);DateTimedatetime20M.AssertModel(models[13],_testData[23], false);DateTimedatetime20M.AssertModel(models[14],_testData[24], false);DateTimedatetime20M.AssertModel(models[15],_testData[25], false);DateTimedatetime20M.AssertModel(models[16],_testData[26], false);DateTimedatetime20M.AssertModel(models[17],_testData[27], false);DateTimedatetime20M.AssertModel(models[18],_testData[28], false);DateTimedatetime20M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
DateTimedatetime20M.AssertModel(models[0],_testData[11], false);DateTimedatetime20M.AssertModel(models[1],_testData[12], false);DateTimedatetime20M.AssertModel(models[2],_testData[13], false);DateTimedatetime20M.AssertModel(models[3],_testData[14], false);DateTimedatetime20M.AssertModel(models[4],_testData[15], false);DateTimedatetime20M.AssertModel(models[5],_testData[16], false);DateTimedatetime20M.AssertModel(models[6],_testData[17], false);DateTimedatetime20M.AssertModel(models[7],_testData[18], false);DateTimedatetime20M.AssertModel(models[8],_testData[19], false);DateTimedatetime20M.AssertModel(models[9],_testData[20], false);DateTimedatetime20M.AssertModel(models[10],_testData[21], false);DateTimedatetime20M.AssertModel(models[11],_testData[22], false);DateTimedatetime20M.AssertModel(models[12],_testData[23], false);DateTimedatetime20M.AssertModel(models[13],_testData[24], false);DateTimedatetime20M.AssertModel(models[14],_testData[25], false);DateTimedatetime20M.AssertModel(models[15],_testData[26], false);DateTimedatetime20M.AssertModel(models[16],_testData[27], false);DateTimedatetime20M.AssertModel(models[17],_testData[28], false);DateTimedatetime20M.AssertModel(models[18],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 10, hour: 13, minute: 54, second: 7, millisecond: 236, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 3, hour: 2, minute: 3, second: 9, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 9, hour: 1, minute: 47, second: 14, millisecond: 488, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 19, hour: 6, minute: 52, second: 17, millisecond: 472, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 12, hour: 12, minute: 21, second: 46, millisecond: 210, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 11, minute: 48, second: 10, millisecond: 149, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 2, hour: 21, minute: 43, second: 55, millisecond: 274, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 4, hour: 14, minute: 24, second: 15, millisecond: 349, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 1, hour: 20, minute: 8, second: 1, millisecond: 236, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 18, hour: 1, minute: 3, second: 43, millisecond: 561, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 6, hour: 12, minute: 17, second: 6, millisecond: 173, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 12, hour: 3, minute: 53, second: 33, millisecond: 494, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 5, hour: 14, minute: 14, second: 55, millisecond: 38, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 7, hour: 18, minute: 33, second: 13, millisecond: 648, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 21, minute: 53, second: 26, millisecond: 386, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 18, minute: 54, second: 14, millisecond: 436, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 19, hour: 19, minute: 10, second: 57, millisecond: 233, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 11, hour: 17, minute: 41, second: 49, millisecond: 198, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 14, hour: 21, minute: 33, second: 29, millisecond: 279, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 9, hour: 18, minute: 19, second: 55, millisecond: 794, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 4, hour: 7, minute: 6, second: 39, millisecond: 709, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 15, hour: 5, minute: 49, second: 22, millisecond: 834, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 4, hour: 1, minute: 7, second: 44, millisecond: 106, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 9, hour: 7, minute: 33, second: 39, millisecond: 134, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 10, hour: 2, minute: 39, second: 9, millisecond: 825, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 5, hour: 12, minute: 4, second: 13, millisecond: 865, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 16, hour: 1, minute: 16, second: 49, millisecond: 887, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 12, hour: 20, minute: 9, second: 25, millisecond: 939, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 10, hour: 7, minute: 51, second: 53, millisecond: 69, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 54, second: 58, millisecond: 710, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 10, hour: 12, minute: 21, second: 35, millisecond: 110, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 18, hour: 4, minute: 16, second: 42, millisecond: 884, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 19, hour: 13, minute: 27, second: 18, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 12, hour: 16, minute: 19, second: 2, millisecond: 500, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 10, hour: 8, minute: 28, second: 28, millisecond: 321, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 2, hour: 17, minute: 49, second: 17, millisecond: 725, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 11, hour: 10, minute: 11, second: 3, millisecond: 410, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 12, hour: 18, minute: 17, second: 39, millisecond: 193, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 5, hour: 8, minute: 28, second: 25, millisecond: 64, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 14, hour: 6, minute: 51, second: 48, millisecond: 209, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 43, second: 24, millisecond: 420, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 17, hour: 5, minute: 31, second: 29, millisecond: 552, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 13, hour: 18, minute: 33, second: 18, millisecond: 792, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 17, hour: 1, minute: 27, second: 25, millisecond: 185, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 17, hour: 16, minute: 15, second: 55, millisecond: 705, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 12, hour: 7, minute: 17, second: 54, millisecond: 121, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 14, hour: 21, minute: 29, second: 10, millisecond: 514, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 11, hour: 3, minute: 2, second: 25, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 18, hour: 7, minute: 50, second: 33, millisecond: 53, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 12, hour: 11, minute: 37, second: 27, millisecond: 522, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 1, second: 23, millisecond: 24, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 15, minute: 26, second: 12, millisecond: 430, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 8, hour: 22, minute: 57, second: 29, millisecond: 39, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 14, hour: 11, minute: 7, second: 34, millisecond: 451, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 19, hour: 9, minute: 37, second: 31, millisecond: 770, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 19, hour: 10, minute: 30, second: 20, millisecond: 778, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 17, hour: 22, minute: 11, second: 55, millisecond: 512, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 14, hour: 2, minute: 31, second: 44, millisecond: 438, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 16, hour: 8, minute: 14, second: 40, millisecond: 445, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 14, hour: 19, minute: 9, second: 16, millisecond: 375, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 9, hour: 7, minute: 26, second: 16, millisecond: 912, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 13, hour: 19, minute: 37, second: 51, millisecond: 669, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 15, hour: 19, minute: 42, second: 23, millisecond: 744, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 10, minute: 33, second: 33, millisecond: 493, kind: DateTimeKind.Local))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 10, hour: 13, minute: 54, second: 7, millisecond: 236, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 3, hour: 2, minute: 3, second: 9, millisecond: 345, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 9, hour: 1, minute: 47, second: 14, millisecond: 488, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 19, hour: 6, minute: 52, second: 17, millisecond: 472, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 12, hour: 12, minute: 21, second: 46, millisecond: 210, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 11, minute: 48, second: 10, millisecond: 149, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 2, hour: 21, minute: 43, second: 55, millisecond: 274, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 4, hour: 14, minute: 24, second: 15, millisecond: 349, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 1, hour: 20, minute: 8, second: 1, millisecond: 236, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 18, hour: 1, minute: 3, second: 43, millisecond: 561, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 6, hour: 12, minute: 17, second: 6, millisecond: 173, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 12, hour: 3, minute: 53, second: 33, millisecond: 494, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 5, hour: 14, minute: 14, second: 55, millisecond: 38, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 7, hour: 18, minute: 33, second: 13, millisecond: 648, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 21, minute: 53, second: 26, millisecond: 386, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 18, minute: 54, second: 14, millisecond: 436, kind: DateTimeKind.Local))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1968, month: 10, day: 19, hour: 19, minute: 10, second: 57, millisecond: 233, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 11, hour: 17, minute: 41, second: 49, millisecond: 198, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2013, month: 10, day: 14, hour: 21, minute: 33, second: 29, millisecond: 279, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 9, hour: 18, minute: 19, second: 55, millisecond: 794, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 4, hour: 7, minute: 6, second: 39, millisecond: 709, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 15, hour: 5, minute: 49, second: 22, millisecond: 834, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 4, hour: 1, minute: 7, second: 44, millisecond: 106, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 9, hour: 7, minute: 33, second: 39, millisecond: 134, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 10, hour: 2, minute: 39, second: 9, millisecond: 825, kind: DateTimeKind.Local))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 5, hour: 12, minute: 4, second: 13, millisecond: 865, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 16, hour: 1, minute: 16, second: 49, millisecond: 887, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 12, hour: 20, minute: 9, second: 25, millisecond: 939, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 10, hour: 7, minute: 51, second: 53, millisecond: 69, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 8, hour: 4, minute: 54, second: 58, millisecond: 710, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 10, hour: 12, minute: 21, second: 35, millisecond: 110, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 18, hour: 4, minute: 16, second: 42, millisecond: 884, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 19, hour: 13, minute: 27, second: 18, millisecond: 995, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 12, hour: 16, minute: 19, second: 2, millisecond: 500, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 10, hour: 8, minute: 28, second: 28, millisecond: 321, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 2, hour: 17, minute: 49, second: 17, millisecond: 725, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 11, hour: 10, minute: 11, second: 3, millisecond: 410, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 12, hour: 18, minute: 17, second: 39, millisecond: 193, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 5, hour: 8, minute: 28, second: 25, millisecond: 64, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 14, hour: 6, minute: 51, second: 48, millisecond: 209, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 3, hour: 18, minute: 43, second: 24, millisecond: 420, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 17, hour: 5, minute: 31, second: 29, millisecond: 552, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 13, hour: 18, minute: 33, second: 18, millisecond: 792, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 17, hour: 1, minute: 27, second: 25, millisecond: 185, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 17, hour: 16, minute: 15, second: 55, millisecond: 705, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 12, hour: 7, minute: 17, second: 54, millisecond: 121, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 14, hour: 21, minute: 29, second: 10, millisecond: 514, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 11, hour: 3, minute: 2, second: 25, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 18, hour: 7, minute: 50, second: 33, millisecond: 53, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 12, hour: 11, minute: 37, second: 27, millisecond: 522, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 1, hour: 12, minute: 1, second: 23, millisecond: 24, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 10, hour: 15, minute: 26, second: 12, millisecond: 430, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 8, hour: 22, minute: 57, second: 29, millisecond: 39, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1921, month: 10, day: 14, hour: 11, minute: 7, second: 34, millisecond: 451, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 19, hour: 9, minute: 37, second: 31, millisecond: 770, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 19, hour: 10, minute: 30, second: 20, millisecond: 778, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 17, hour: 22, minute: 11, second: 55, millisecond: 512, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1925, month: 10, day: 14, hour: 2, minute: 31, second: 44, millisecond: 438, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 16, hour: 8, minute: 14, second: 40, millisecond: 445, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 14, hour: 19, minute: 9, second: 16, millisecond: 375, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 9, hour: 7, minute: 26, second: 16, millisecond: 912, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 13, hour: 19, minute: 37, second: 51, millisecond: 669, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 15, hour: 19, minute: 42, second: 23, millisecond: 744, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 14, hour: 10, minute: 33, second: 33, millisecond: 493, kind: DateTimeKind.Local))));

            }
        }

#endregion

    }
}


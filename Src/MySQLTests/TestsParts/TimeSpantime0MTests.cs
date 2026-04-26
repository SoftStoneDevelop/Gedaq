

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
    internal partial interface ITimeSpanSingleTypetime
    {
    }
    
    internal partial class TimeSpanSingleTypetime : ITimeSpanSingleTypetime
    {


#region TestData

        private readonly TimeSpantime0M[] _testData = new TimeSpantime0M[]
        {
            new TimeSpantime0M
{
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 5, milliseconds: 369),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 56, milliseconds: 499),
    ModelInner = new TimeSpantime0MI
{
    Id = 1,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 699),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 40, milliseconds: 253),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 15,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 58, milliseconds: 966),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 20, milliseconds: 409),
},
            new TimeSpantime0M
{
    Id = 23,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 40, milliseconds: 937),
    ModelInner = new TimeSpantime0MI
{
    Id = 5,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 42, milliseconds: 44),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 0, milliseconds: 416),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 19, milliseconds: 386),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 31,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 18, milliseconds: 978),
    ModelInner = new TimeSpantime0MI
{
    Id = 10,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 19, milliseconds: 886),
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 23, milliseconds: 232),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 35,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 12, milliseconds: 858),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 2, milliseconds: 220),
},
            new TimeSpantime0M
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 54, milliseconds: 460),
    ModelInner = new TimeSpantime0MI
{
    Id = 12,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 37, milliseconds: 294),
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 8, milliseconds: 925),
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 26, milliseconds: 663),
},
            new TimeSpantime0M
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 15, milliseconds: 763),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 2, milliseconds: 901),
},
            new TimeSpantime0M
{
    Id = 55,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 10, milliseconds: 478),
    ModelInner = new TimeSpantime0MI
{
    Id = 17,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 36, milliseconds: 666),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 43, milliseconds: 500),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 36, milliseconds: 860),
},
            new TimeSpantime0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 31, milliseconds: 460),
    ModelInner = new TimeSpantime0MI
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 27, milliseconds: 670),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 52, milliseconds: 44),
},
            new TimeSpantime0M
{
    Id = 62,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 52, milliseconds: 319),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 0, milliseconds: 729),
    ModelInner = new TimeSpantime0MI
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 12, milliseconds: 263),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 18, milliseconds: 614),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 37, milliseconds: 890),
},
            new TimeSpantime0M
{
    Id = 79,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 57, milliseconds: 687),
    ModelInner = new TimeSpantime0MI
{
    Id = 36,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 23, milliseconds: 434),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 81,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 51, milliseconds: 195),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 90,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 40, milliseconds: 546),
    ModelInner = new TimeSpantime0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 55, milliseconds: 372),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 55, milliseconds: 354),
},
            new TimeSpantime0M
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 38, milliseconds: 838),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 97,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 54, milliseconds: 762),
    ModelInner = new TimeSpantime0MI
{
    Id = 48,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 0, milliseconds: 273),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 9, milliseconds: 701),
},
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 30, milliseconds: 176),
},
            new TimeSpantime0M
{
    Id = 102,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 26, milliseconds: 813),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 37, milliseconds: 112),
},
            new TimeSpantime0M
{
    Id = 103,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 17, milliseconds: 767),
    ModelInner = new TimeSpantime0MI
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 3, milliseconds: 223),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 107,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 49, milliseconds: 307),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 34, milliseconds: 950),
},
            new TimeSpantime0M
{
    Id = 110,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 56, milliseconds: 535),
    ModelInner = new TimeSpantime0MI
{
    Id = 58,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 5, milliseconds: 473),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 117,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 39, milliseconds: 571),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 37, milliseconds: 223),
},
            new TimeSpantime0M
{
    Id = 126,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 34, milliseconds: 383),
    ModelInner = new TimeSpantime0MI
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 27, milliseconds: 61),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 40, milliseconds: 447),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 127,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 5, milliseconds: 9),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 128,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 37, milliseconds: 154),
    ModelInner = new TimeSpantime0MI
{
    Id = 70,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 45, milliseconds: 631),
    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 46, milliseconds: 85),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 132,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 47, milliseconds: 196),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 51, milliseconds: 100),
},
            new TimeSpantime0M
{
    Id = 134,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 27, milliseconds: 80),
    ModelInner = new TimeSpantime0MI
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 32, milliseconds: 965),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(11)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(11))]
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17), 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0m(
	id,
    value,
    nullablevalue,
    timespantime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantime0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(11)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(11),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0m(
	id,
    value,
    nullablevalue,
    timespantime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantime0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models = await ((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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

                var models = await ((ITimeSpanSingleTypetime)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((ITimeSpanSingleTypetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanSingleTypetime)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanSingleTypetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
                var models = await ((ITimeSpanSingleTypetime)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatTimeSpantime0M.AssertModel(models[0],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatTimeSpantime0M.AssertModel(models[0],_testData[5], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[6], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[7], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[8], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[9], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[10], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[11], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[18],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[19],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[20],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[21],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[22],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[23],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[24],_testData[29], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatTimeSpantime0M.AssertModel(models[0],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatTimeSpantime0M.AssertModel(models[0],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[29], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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

                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeSpantime0M.AssertModel(models[0],_testData[6], false);TimeSpantime0M.AssertModel(models[1],_testData[7], false);TimeSpantime0M.AssertModel(models[2],_testData[8], false);TimeSpantime0M.AssertModel(models[3],_testData[9], false);TimeSpantime0M.AssertModel(models[4],_testData[10], false);TimeSpantime0M.AssertModel(models[5],_testData[11], false);TimeSpantime0M.AssertModel(models[6],_testData[12], false);TimeSpantime0M.AssertModel(models[7],_testData[13], false);TimeSpantime0M.AssertModel(models[8],_testData[14], false);TimeSpantime0M.AssertModel(models[9],_testData[15], false);TimeSpantime0M.AssertModel(models[10],_testData[16], false);TimeSpantime0M.AssertModel(models[11],_testData[17], false);TimeSpantime0M.AssertModel(models[12],_testData[18], false);TimeSpantime0M.AssertModel(models[13],_testData[19], false);TimeSpantime0M.AssertModel(models[14],_testData[20], false);TimeSpantime0M.AssertModel(models[15],_testData[21], false);TimeSpantime0M.AssertModel(models[16],_testData[22], false);TimeSpantime0M.AssertModel(models[17],_testData[23], false);TimeSpantime0M.AssertModel(models[18],_testData[24], false);TimeSpantime0M.AssertModel(models[19],_testData[25], false);TimeSpantime0M.AssertModel(models[20],_testData[26], false);TimeSpantime0M.AssertModel(models[21],_testData[27], false);TimeSpantime0M.AssertModel(models[22],_testData[28], false);TimeSpantime0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeSpantime0M.AssertModel(models[0],_testData[24], false);TimeSpantime0M.AssertModel(models[1],_testData[25], false);TimeSpantime0M.AssertModel(models[2],_testData[26], false);TimeSpantime0M.AssertModel(models[3],_testData[27], false);TimeSpantime0M.AssertModel(models[4],_testData[28], false);TimeSpantime0M.AssertModel(models[5],_testData[29], false);
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

                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
TimeSpantime0M.AssertModel(models[0],_testData[21], false);TimeSpantime0M.AssertModel(models[1],_testData[22], false);TimeSpantime0M.AssertModel(models[2],_testData[23], false);TimeSpantime0M.AssertModel(models[3],_testData[24], false);TimeSpantime0M.AssertModel(models[4],_testData[25], false);TimeSpantime0M.AssertModel(models[5],_testData[26], false);TimeSpantime0M.AssertModel(models[6],_testData[27], false);TimeSpantime0M.AssertModel(models[7],_testData[28], false);TimeSpantime0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeSpantime0M.AssertModel(models[0],_testData[6], false);TimeSpantime0M.AssertModel(models[1],_testData[7], false);TimeSpantime0M.AssertModel(models[2],_testData[8], false);TimeSpantime0M.AssertModel(models[3],_testData[9], false);TimeSpantime0M.AssertModel(models[4],_testData[10], false);TimeSpantime0M.AssertModel(models[5],_testData[11], false);TimeSpantime0M.AssertModel(models[6],_testData[12], false);TimeSpantime0M.AssertModel(models[7],_testData[13], false);TimeSpantime0M.AssertModel(models[8],_testData[14], false);TimeSpantime0M.AssertModel(models[9],_testData[15], false);TimeSpantime0M.AssertModel(models[10],_testData[16], false);TimeSpantime0M.AssertModel(models[11],_testData[17], false);TimeSpantime0M.AssertModel(models[12],_testData[18], false);TimeSpantime0M.AssertModel(models[13],_testData[19], false);TimeSpantime0M.AssertModel(models[14],_testData[20], false);TimeSpantime0M.AssertModel(models[15],_testData[21], false);TimeSpantime0M.AssertModel(models[16],_testData[22], false);TimeSpantime0M.AssertModel(models[17],_testData[23], false);TimeSpantime0M.AssertModel(models[18],_testData[24], false);TimeSpantime0M.AssertModel(models[19],_testData[25], false);TimeSpantime0M.AssertModel(models[20],_testData[26], false);TimeSpantime0M.AssertModel(models[21],_testData[27], false);TimeSpantime0M.AssertModel(models[22],_testData[28], false);TimeSpantime0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 90, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpantime0M.AssertModel(models[0],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatTimeSpantime0M.AssertModel(models[0],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[29], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatTimeSpantime0M.AssertModel(models[0],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatTimeSpantime0M.AssertModel(models[0],_testData[4], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[5], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[6], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[7], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[8], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[9], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[10], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[11], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[18],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[19],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[20],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[21],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[22],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[23],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[24],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[25],_testData[29], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpantime0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatchAsync(connection, 62, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeSpantime0M.AssertModel(models[0],_testData[13], false);TimeSpantime0M.AssertModel(models[1],_testData[14], false);TimeSpantime0M.AssertModel(models[2],_testData[15], false);TimeSpantime0M.AssertModel(models[3],_testData[16], false);TimeSpantime0M.AssertModel(models[4],_testData[17], false);TimeSpantime0M.AssertModel(models[5],_testData[18], false);TimeSpantime0M.AssertModel(models[6],_testData[19], false);TimeSpantime0M.AssertModel(models[7],_testData[20], false);TimeSpantime0M.AssertModel(models[8],_testData[21], false);TimeSpantime0M.AssertModel(models[9],_testData[22], false);TimeSpantime0M.AssertModel(models[10],_testData[23], false);TimeSpantime0M.AssertModel(models[11],_testData[24], false);TimeSpantime0M.AssertModel(models[12],_testData[25], false);TimeSpantime0M.AssertModel(models[13],_testData[26], false);TimeSpantime0M.AssertModel(models[14],_testData[27], false);TimeSpantime0M.AssertModel(models[15],_testData[28], false);TimeSpantime0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
TimeSpantime0M.AssertModel(models[0],_testData[22], false);TimeSpantime0M.AssertModel(models[1],_testData[23], false);TimeSpantime0M.AssertModel(models[2],_testData[24], false);TimeSpantime0M.AssertModel(models[3],_testData[25], false);TimeSpantime0M.AssertModel(models[4],_testData[26], false);TimeSpantime0M.AssertModel(models[5],_testData[27], false);TimeSpantime0M.AssertModel(models[6],_testData[28], false);TimeSpantime0M.AssertModel(models[7],_testData[29], false);
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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatch(connection, 117, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
TimeSpantime0M.AssertModel(models[0],_testData[25], false);TimeSpantime0M.AssertModel(models[1],_testData[26], false);TimeSpantime0M.AssertModel(models[2],_testData[27], false);TimeSpantime0M.AssertModel(models[3],_testData[28], false);TimeSpantime0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
TimeSpantime0M.AssertModel(models[0],_testData[15], false);TimeSpantime0M.AssertModel(models[1],_testData[16], false);TimeSpantime0M.AssertModel(models[2],_testData[17], false);TimeSpantime0M.AssertModel(models[3],_testData[18], false);TimeSpantime0M.AssertModel(models[4],_testData[19], false);TimeSpantime0M.AssertModel(models[5],_testData[20], false);TimeSpantime0M.AssertModel(models[6],_testData[21], false);TimeSpantime0M.AssertModel(models[7],_testData[22], false);TimeSpantime0M.AssertModel(models[8],_testData[23], false);TimeSpantime0M.AssertModel(models[9],_testData[24], false);TimeSpantime0M.AssertModel(models[10],_testData[25], false);TimeSpantime0M.AssertModel(models[11],_testData[26], false);TimeSpantime0M.AssertModel(models[12],_testData[27], false);TimeSpantime0M.AssertModel(models[13],_testData[28], false);TimeSpantime0M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
TimeSpantime0M.AssertModel(models[0],_testData[25], false);TimeSpantime0M.AssertModel(models[1],_testData[26], false);TimeSpantime0M.AssertModel(models[2],_testData[27], false);TimeSpantime0M.AssertModel(models[3],_testData[28], false);TimeSpantime0M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
TimeSpantime0M.AssertModel(models[0],_testData[20], false);TimeSpantime0M.AssertModel(models[1],_testData[21], false);TimeSpantime0M.AssertModel(models[2],_testData[22], false);TimeSpantime0M.AssertModel(models[3],_testData[23], false);TimeSpantime0M.AssertModel(models[4],_testData[24], false);TimeSpantime0M.AssertModel(models[5],_testData[25], false);TimeSpantime0M.AssertModel(models[6],_testData[26], false);TimeSpantime0M.AssertModel(models[7],_testData[27], false);TimeSpantime0M.AssertModel(models[8],_testData[28], false);TimeSpantime0M.AssertModel(models[9],_testData[29], false);
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
            asPartInterface: typeof(ITimeSpanSingleTypetime))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 5, milliseconds: 369))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 56, milliseconds: 499))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 699))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 40, milliseconds: 253))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 58, milliseconds: 966))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 20, milliseconds: 409))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 40, milliseconds: 937))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 42, milliseconds: 44))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 0, milliseconds: 416))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 19, milliseconds: 386))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 18, milliseconds: 978))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 19, milliseconds: 886))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 23, milliseconds: 232))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 12, milliseconds: 858))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 2, milliseconds: 220))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 54, milliseconds: 460))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 37, milliseconds: 294))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 8, milliseconds: 925))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 26, milliseconds: 663))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 15, milliseconds: 763))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 2, milliseconds: 901))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 10, milliseconds: 478))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 36, milliseconds: 666))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 43, milliseconds: 500))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 36, milliseconds: 860))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 31, milliseconds: 460))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 27, milliseconds: 670))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 52, milliseconds: 44))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 52, milliseconds: 319))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 0, milliseconds: 729))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 12, milliseconds: 263))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 18, milliseconds: 614))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 37, milliseconds: 890))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 57, milliseconds: 687))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 23, milliseconds: 434))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 51, milliseconds: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 40, milliseconds: 546))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 55, milliseconds: 372))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 55, milliseconds: 354))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 38, milliseconds: 838))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 54, milliseconds: 762))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 0, milliseconds: 273))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 9, milliseconds: 701))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 30, milliseconds: 176))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 26, milliseconds: 813))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 37, milliseconds: 112))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 17, milliseconds: 767))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 3, milliseconds: 223))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 49, milliseconds: 307))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 34, milliseconds: 950))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 56, milliseconds: 535))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 5, milliseconds: 473))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 39, milliseconds: 571))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 37, milliseconds: 223))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 34, milliseconds: 383))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 27, milliseconds: 61))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 40, milliseconds: 447))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 5, milliseconds: 9))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 37, milliseconds: 154))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 45, milliseconds: 631))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 46, milliseconds: 85))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 47, milliseconds: 196))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 51, milliseconds: 100))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 27, milliseconds: 80))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 32, milliseconds: 965))));//InnerModel.Value

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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 5, milliseconds: 369))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 56, milliseconds: 499))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 699))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 40, milliseconds: 253))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 58, milliseconds: 966))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 20, milliseconds: 409))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 40, milliseconds: 937))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 42, milliseconds: 44))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 0, milliseconds: 416))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 19, milliseconds: 386))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 18, milliseconds: 978))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 19, milliseconds: 886))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 23, milliseconds: 232))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 12, milliseconds: 858))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 2, milliseconds: 220))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 54, milliseconds: 460))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 37, milliseconds: 294))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 8, milliseconds: 925))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 26, milliseconds: 663))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 15, milliseconds: 763))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 2, milliseconds: 901))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 10, milliseconds: 478))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 36, milliseconds: 666))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 43, milliseconds: 500))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 36, milliseconds: 860))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 31, milliseconds: 460))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 27, milliseconds: 670))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 52, milliseconds: 44))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 52, milliseconds: 319))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 0, milliseconds: 729))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 12, milliseconds: 263))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 18, milliseconds: 614))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 37, milliseconds: 890))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 57, milliseconds: 687))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 23, milliseconds: 434))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 51, milliseconds: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 40, milliseconds: 546))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 55, milliseconds: 372))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 55, milliseconds: 354))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 38, milliseconds: 838))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 54, milliseconds: 762))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 0, milliseconds: 273))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 9, milliseconds: 701))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 30, milliseconds: 176))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 26, milliseconds: 813))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 37, milliseconds: 112))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 17, milliseconds: 767))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 3, milliseconds: 223))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 49, milliseconds: 307))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 34, milliseconds: 950))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 56, milliseconds: 535))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 5, milliseconds: 473))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 39, milliseconds: 571))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 37, milliseconds: 223))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 34, milliseconds: 383))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 27, milliseconds: 61))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 40, milliseconds: 447))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 5, milliseconds: 9))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 37, milliseconds: 154))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 45, milliseconds: 631))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 46, milliseconds: 85))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 47, milliseconds: 196))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 51, milliseconds: 100))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 27, milliseconds: 80))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 32, milliseconds: 965))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


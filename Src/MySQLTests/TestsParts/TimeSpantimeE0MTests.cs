

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

        private readonly TimeSpantimeE0M[] _testData = new TimeSpantimeE0M[]
        {
            new TimeSpantimeE0M
{
    Id = 7,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 30, milliseconds: 187),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 17, milliseconds: 39),
},
            new TimeSpantimeE0M
{
    Id = 8,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 53, milliseconds: 947),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 48, milliseconds: 856),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 28, milliseconds: 690),
},
            new TimeSpantimeE0M
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 53, milliseconds: 70),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 49, milliseconds: 557),
},
            new TimeSpantimeE0M
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 3, milliseconds: 969),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 7,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 40, milliseconds: 3),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 43, milliseconds: 710),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 24,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 50, milliseconds: 628),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 57, milliseconds: 586),
},
            new TimeSpantimeE0M
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 54, milliseconds: 750),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 13,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 12, milliseconds: 919),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 26, seconds: 29, milliseconds: 392),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 28,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 8, milliseconds: 35),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 27, milliseconds: 136),
},
            new TimeSpantimeE0M
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 4, milliseconds: 706),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 24, milliseconds: 419),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 0, milliseconds: 724),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 44, milliseconds: 787),
},
            new TimeSpantimeE0M
{
    Id = 45,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 7, milliseconds: 48),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 19,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 47, seconds: 41, milliseconds: 312),
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 1, milliseconds: 20),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 50,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 45, milliseconds: 778),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 49, milliseconds: 342),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 24,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 3, milliseconds: 435),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 858),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 31, milliseconds: 730),
},
            new TimeSpantimeE0M
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 24, milliseconds: 91),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 10, milliseconds: 972),
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 33, milliseconds: 313),
},
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 37, milliseconds: 649),
},
            new TimeSpantimeE0M
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 40, milliseconds: 78),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 18, milliseconds: 257),
},
            new TimeSpantimeE0M
{
    Id = 73,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 40, milliseconds: 983),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 35,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 18, milliseconds: 768),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 78,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 42, milliseconds: 215),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 79,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 14, milliseconds: 530),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 32, milliseconds: 868),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 85,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 2, milliseconds: 762),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 31, milliseconds: 117),
},
            new TimeSpantimeE0M
{
    Id = 89,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 4, milliseconds: 111),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 46,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 32),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 822),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 57, milliseconds: 626),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 97,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 22, milliseconds: 215),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 10, milliseconds: 612),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 55, milliseconds: 651),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 98,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 31, milliseconds: 457),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 104,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 21, milliseconds: 151),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 53,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 29, milliseconds: 927),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 112,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 478),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 41, milliseconds: 585),
},
            new TimeSpantimeE0M
{
    Id = 119,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 6, milliseconds: 870),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 59,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 5, milliseconds: 127),
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 12, milliseconds: 119),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 125,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 20, milliseconds: 959),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 130,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 14, milliseconds: 127),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 63,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 38, milliseconds: 269),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 43, milliseconds: 722),
},
            new TimeSpantimeE0M
{
    Id = 139,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 50, milliseconds: 474),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 145,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 53, milliseconds: 386),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 13, milliseconds: 914),
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 37, milliseconds: 337),
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 25, milliseconds: 533),
},
            new TimeSpantimeE0M
{
    Id = 150,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 42, milliseconds: 753),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 0, milliseconds: 803),
},
            new TimeSpantimeE0M
{
    Id = 157,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 32, milliseconds: 761),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 75,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 45, milliseconds: 782),
    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 43, milliseconds: 209),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 160,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 2, milliseconds: 575),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 164,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 21, milliseconds: 147),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 78,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 11, milliseconds: 370),
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 41, milliseconds: 182),
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 23, milliseconds: 687),
},
            new TimeSpantimeE0M
{
    Id = 169,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 57, milliseconds: 380),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantimee0mi(
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
INSERT INTO gedaqtests.timespantimee0mi(
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantimee0m(
	id,
    value,
    nullablevalue,
    timespantimee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantimee0mi_id
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
                parametrName: "timespantimee0mi_id", 
                methodParametrName: "timespantimee0mi_id", 
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
INSERT INTO gedaqtests.timespantimee0m(
	id,
    value,
    nullablevalue,
    timespantimee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantimee0mi_id
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
                parametrName: "timespantimee0mi_id", 
                methodParametrName: "timespantimee0mi_id", 
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                await((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                ((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
LEFT JOIN gedaqtests.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
                var models = await((ITimeSpanSingleTypetime)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanSingleTypetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                await((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                ((ITimeSpanSingleTypetime)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanSingleTypetime)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
LEFT JOIN gedaqtests.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
                var models = await((ITimeSpanSingleTypetime)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanSingleTypetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                await((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
LEFT JOIN gedaqtests.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[11], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[12], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[13], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[14], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[20],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[21],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[22],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[4], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[5], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[6], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[7], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[8], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[9], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[10], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[11], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[12], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[13], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[14], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[20],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[21],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[22],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[23],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[24],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[25],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[26],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[27],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[28],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[29],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                await((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 24, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantimeE0M>();
                var models2 = new List<FlatTimeSpantimeE0M>();
                ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpantimeE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 45, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[3], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[19],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[20],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[21],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[22],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[23],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[24],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[25],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[26],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[27],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[28],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[29],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[30],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[19],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[20],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[21],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[22],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[23],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[24],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[25],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[26],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[19],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[20],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[21],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[22],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[23],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[24],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[25],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
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
FROM gedaqtests.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 112, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
LEFT JOIN gedaqtests.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((ITimeSpanSingleTypetime)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[34], false);
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
                var models = ((ITimeSpanSingleTypetime)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatch(connection, 160, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[6], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[7], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[8], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[9], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[10], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[11], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[12], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[13], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[14], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[20],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[21],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[22],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[23],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[24],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[25],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[26],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[27],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[28],_testData[34], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                TimeSpantimeE0M.AssertModel(models[0],_testData[22], false);
                TimeSpantimeE0M.AssertModel(models[1],_testData[23], false);
                TimeSpantimeE0M.AssertModel(models[2],_testData[24], false);
                TimeSpantimeE0M.AssertModel(models[3],_testData[25], false);
                TimeSpantimeE0M.AssertModel(models[4],_testData[26], false);
                TimeSpantimeE0M.AssertModel(models[5],_testData[27], false);
                TimeSpantimeE0M.AssertModel(models[6],_testData[28], false);
                TimeSpantimeE0M.AssertModel(models[7],_testData[29], false);
                TimeSpantimeE0M.AssertModel(models[8],_testData[30], false);
                TimeSpantimeE0M.AssertModel(models[9],_testData[31], false);
                TimeSpantimeE0M.AssertModel(models[10],_testData[32], false);
                TimeSpantimeE0M.AssertModel(models[11],_testData[33], false);
                TimeSpantimeE0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                TimeSpantimeE0M.AssertModel(models[0],_testData[29], false);
                TimeSpantimeE0M.AssertModel(models[1],_testData[30], false);
                TimeSpantimeE0M.AssertModel(models[2],_testData[31], false);
                TimeSpantimeE0M.AssertModel(models[3],_testData[32], false);
                TimeSpantimeE0M.AssertModel(models[4],_testData[33], false);
                TimeSpantimeE0M.AssertModel(models[5],_testData[34], false);
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
FROM gedaqtests.timespantimee0m m
LEFT JOIN gedaqtests.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 30, milliseconds: 187))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 17, milliseconds: 39))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 53, milliseconds: 947))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 48, milliseconds: 856))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 28, milliseconds: 690))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 53, milliseconds: 70))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 49, milliseconds: 557))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 3, milliseconds: 969))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 40, milliseconds: 3))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 43, milliseconds: 710))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 50, milliseconds: 628))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 57, milliseconds: 586))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 54, milliseconds: 750))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 12, milliseconds: 919))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 26, seconds: 29, milliseconds: 392))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 8, milliseconds: 35))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 27, milliseconds: 136))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 4, milliseconds: 706))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 24, milliseconds: 419))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 0, milliseconds: 724))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 44, milliseconds: 787))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 7, milliseconds: 48))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 47, seconds: 41, milliseconds: 312))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 1, milliseconds: 20))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 45, milliseconds: 778))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 49, milliseconds: 342))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 3, milliseconds: 435))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 858))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 31, milliseconds: 730))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 24, milliseconds: 91))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 10, milliseconds: 972))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 33, milliseconds: 313))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 37, milliseconds: 649))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 40, milliseconds: 78))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 18, milliseconds: 257))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 40, milliseconds: 983))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 18, milliseconds: 768))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 42, milliseconds: 215))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 14, milliseconds: 530))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 32, milliseconds: 868))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 2, milliseconds: 762))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 31, milliseconds: 117))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 4, milliseconds: 111))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 32))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 822))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 57, milliseconds: 626))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 22, milliseconds: 215))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 10, milliseconds: 612))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 55, milliseconds: 651))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 31, milliseconds: 457))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 21, milliseconds: 151))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 29, milliseconds: 927))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 478))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 41, milliseconds: 585))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 6, milliseconds: 870))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 5, milliseconds: 127))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 12, milliseconds: 119))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 20, milliseconds: 959))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 14, milliseconds: 127))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 38, milliseconds: 269))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 43, milliseconds: 722))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 50, milliseconds: 474))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 53, milliseconds: 386))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 13, milliseconds: 914))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 37, milliseconds: 337))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 25, milliseconds: 533))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 42, milliseconds: 753))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 0, milliseconds: 803))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 32, milliseconds: 761))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 45, milliseconds: 782))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 43, milliseconds: 209))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 2, milliseconds: 575))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 21, milliseconds: 147))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 11, milliseconds: 370))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 41, milliseconds: 182))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 23, milliseconds: 687))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 57, milliseconds: 380))));//Value

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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 30, milliseconds: 187))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 17, milliseconds: 39))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 53, milliseconds: 947))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 48, milliseconds: 856))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 28, milliseconds: 690))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 53, milliseconds: 70))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 49, milliseconds: 557))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 3, milliseconds: 969))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 40, milliseconds: 3))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 43, milliseconds: 710))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 50, milliseconds: 628))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 57, milliseconds: 586))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 54, milliseconds: 750))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 12, milliseconds: 919))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 26, seconds: 29, milliseconds: 392))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 8, milliseconds: 35))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 27, milliseconds: 136))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 4, milliseconds: 706))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 24, milliseconds: 419))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 0, milliseconds: 724))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 44, milliseconds: 787))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 7, milliseconds: 48))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 47, seconds: 41, milliseconds: 312))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 1, milliseconds: 20))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 45, milliseconds: 778))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 49, milliseconds: 342))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 3, milliseconds: 435))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 858))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 31, milliseconds: 730))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 24, milliseconds: 91))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 10, milliseconds: 972))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 33, milliseconds: 313))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 37, milliseconds: 649))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 40, milliseconds: 78))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 18, milliseconds: 257))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 40, milliseconds: 983))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 18, milliseconds: 768))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 42, milliseconds: 215))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 14, milliseconds: 530))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 32, milliseconds: 868))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 2, milliseconds: 762))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 31, milliseconds: 117))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 4, milliseconds: 111))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 32))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 822))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 57, milliseconds: 626))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 22, milliseconds: 215))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 10, milliseconds: 612))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 55, milliseconds: 651))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 31, milliseconds: 457))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 21, milliseconds: 151))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 29, milliseconds: 927))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 57, milliseconds: 478))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 41, milliseconds: 585))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 6, milliseconds: 870))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 5, milliseconds: 127))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 12, milliseconds: 119))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 20, milliseconds: 959))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 14, milliseconds: 127))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 38, milliseconds: 269))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 43, milliseconds: 722))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 50, milliseconds: 474))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 53, milliseconds: 386))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 13, milliseconds: 914))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 37, milliseconds: 337))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 25, milliseconds: 533))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 42, milliseconds: 753))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 0, milliseconds: 803))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 32, milliseconds: 761))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 45, milliseconds: 782))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 43, milliseconds: 209))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 2, milliseconds: 575))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 21, milliseconds: 147))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 11, milliseconds: 370))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 41, milliseconds: 182))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 23, milliseconds: 687))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 57, milliseconds: 380))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

